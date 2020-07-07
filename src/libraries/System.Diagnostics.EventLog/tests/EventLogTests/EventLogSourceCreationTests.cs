// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;
using Microsoft.DotNet.XUnitExtensions;

namespace System.Diagnostics.Tests
{
    public class EventLogSourceCreationTests
    {
        [ActiveIssue("https://github.com/dotnet/runtime/issues/36135")]
        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void CheckSourceExistenceAndDeletion()
        {
            string source = "Source_" + nameof(EventLogSourceCreationTests);
            string log = "SourceExistenceLog";
            try
            {
                EventLog.CreateEventSource(source, log);
                Assert.True(EventLog.SourceExists(source));
            }
            finally
            {
                EventLog.DeleteEventSource(source);
                Helpers.Retry(() => EventLog.Delete(log));  // unlike other tests, throw if delete fails
            }

            Assert.False(EventLog.SourceExists(source));
        }

        [ActiveIssue("https://github.com/dotnet/runtime/issues/36135")]
        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        [SkipOnTargetFramework(TargetFrameworkMonikers.NetFramework)]
        public void LogNameWithSame8FirstChars_NetCore()
        {
            string firstSource = "FirstSource_" + nameof(LogNameWithSame8FirstChars_NetCore);
            string firstLog = "LogNameWithSame8FirstChars";
            string secondSource = "SecondSource_" + nameof(LogNameWithSame8FirstChars_NetCore);
            string secondLog = "LogNameWithSame8FirstCharsDuplicate";

            // No Exception should be thrown.
            try
            {
                EventLog.CreateEventSource(firstSource, firstLog);
                Assert.True(EventLog.SourceExists(firstSource));
                EventLog.CreateEventSource(secondSource, secondLog);
                Assert.True(EventLog.SourceExists(secondSource));
            }
            finally
            {
                EventLog.DeleteEventSource(firstSource);
                Helpers.Retry(() => EventLog.Delete(firstLog));
                EventLog.DeleteEventSource(secondSource);
                Helpers.Retry(() => EventLog.Delete(secondLog));
            }
        }

        [ActiveIssue("https://github.com/dotnet/runtime/issues/36135")]
        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        [SkipOnTargetFramework(~TargetFrameworkMonikers.NetFramework)]
        public void LogNameWithSame8FirstChars_NetFramework()
        {
            string firstSource = "FirstSource_" + nameof(LogNameWithSame8FirstChars_NetFramework);
            string firstLog = "LogNameWithSame8FirstChars";
            string secondSource = "SecondSource_" + nameof(LogNameWithSame8FirstChars_NetFramework);
            string secondLog = "LogNameWithSame8FirstCharsDuplicate";

            try
            {
                EventLog.CreateEventSource(firstSource, firstLog);
                Assert.True(EventLog.SourceExists(firstSource));
                Assert.Throws<ArgumentException>(() => EventLog.CreateEventSource(secondSource, secondLog));
            }
            finally
            {
                EventLog.DeleteEventSource(firstSource);
                Helpers.Retry(() => EventLog.Delete(firstLog));
            }
        }

        [ConditionalTheory(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        [InlineData("AppEvent")]
        [InlineData("SecEvent")]
        [InlineData("SysEvent")]
        public void SystemLogNamesThrowException(string logName)
        {
            string source = "Source_" + nameof(SystemLogNamesThrowException);
            Assert.False(EventLog.SourceExists(source));
            Assert.Throws<ArgumentException>(() => EventLog.CreateEventSource(source, logName));
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.SupportsEventLogs))]
        public void CheckSourceExistsArgumentNull()
        {
            Assert.False(EventLog.SourceExists(null));
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void DeleteUnregisteredSource()
        {
            Assert.Throws<ArgumentException>(() => EventLog.DeleteEventSource(Guid.NewGuid().ToString("N")));
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void LogNameNullMeansApplicationLog()
        {
            string source = "Source_" + nameof(LogNameNullMeansApplicationLog);

            try
            {
                EventLog.CreateEventSource(source, null);
                Assert.True(EventLog.SourceExists(source));
                Assert.Equal("Application", EventLog.LogNameFromSourceName(source, "."));
            }
            finally
            {
                EventLog.DeleteEventSource(source);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void SourceNameNull()
        {
            Assert.Throws<ArgumentException>(() => EventLog.CreateEventSource(null, "logName"));
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void IncorrectLogName()
        {
            string source = "Source_" + nameof(IncorrectLogName);
            Assert.Throws<ArgumentException>(() => EventLog.CreateEventSource(source, "?"));
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void SourceNameMaxLengthExceeded()
        {
            string source = new string('s', 254);
            Assert.Throws<ArgumentException>(() => EventLog.CreateEventSource(source, null));
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void SourceDataNull()
        {
            Assert.Throws<ArgumentNullException>(() => EventLog.CreateEventSource(null));
        }

        [ActiveIssue("https://github.com/dotnet/runtime/issues/36135")]
        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void SourceAlreadyExistsWhenCreatingSource()
        {
            string source = "Source_" + nameof(SourceAlreadyExistsWhenCreatingSource);
            string log = "ExistingSource";
            try
            {
                EventLog.CreateEventSource(source, log);
                Assert.True(EventLog.SourceExists(source));
                Assert.Throws<ArgumentException>(() => EventLog.CreateEventSource(source, log));
            }
            finally
            {
                EventLog.DeleteEventSource(source);
                Helpers.RetrySilently(() => EventLog.Delete(log));
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndSupportsEventLogs))]
        public void LogNameAlreadyExists_Throws()
        {
            string source = "Source_" + nameof(LogNameAlreadyExists_Throws);
            string log = "AppEvent";

            Assert.Throws<ArgumentException>(() => EventLog.CreateEventSource(source, log));
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.SupportsEventLogs))]
        public void EventSourceCategoryCount_Invalid()
        {
            string log = "InvalidData";
            string source = "Source_" + nameof(EventSourceCategoryCount_Invalid);

            EventSourceCreationData mySourceData = new EventSourceCreationData(source, log);
            Assert.Throws<ArgumentOutOfRangeException>(() => mySourceData.CategoryCount = -1);
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.SupportsEventLogs))]
        public void MessageResourceFile_Set()
        {
            string messageFile = "ResourceFile";
            string source = "Source" + nameof(MessageResourceFile_Set);
            string log = "MessageResourceFile";
            EventSourceCreationData sourceData = new EventSourceCreationData(source, log);
            sourceData.MessageResourceFile = messageFile;
            Assert.Equal(messageFile, sourceData.MessageResourceFile);
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.SupportsEventLogs))]
        public void CategoryResourceFile_Set()
        {
            string messageFile = "ResourceFile";
            string source = "Source" + nameof(CategoryResourceFile_Set);
            string log = "MessageResourceFile";
            EventSourceCreationData sourceData = new EventSourceCreationData(source, log);
            sourceData.CategoryResourceFile = messageFile;
            Assert.Equal(messageFile, sourceData.CategoryResourceFile);
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.SupportsEventLogs))]
        public void ParameterResourceFile_Set()
        {
            string messageFile = "ResourceFile";
            string source = "Source" + nameof(ParameterResourceFile_Set);
            string log = "MessageResourceFile";
            EventSourceCreationData sourceData = new EventSourceCreationData(source, log);
            sourceData.ParameterResourceFile = messageFile;
            Assert.Equal(messageFile, sourceData.ParameterResourceFile);
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.SupportsEventLogs))]
        public void CategoryCount_Set()
        {
            string source = "Source" + nameof(CategoryCount_Set);
            string log = "MessageResourceFile";
            EventSourceCreationData sourceData = new EventSourceCreationData(source, log);
            sourceData.CategoryCount = 2;
            Assert.Equal(2, sourceData.CategoryCount);
        }
    }
}
