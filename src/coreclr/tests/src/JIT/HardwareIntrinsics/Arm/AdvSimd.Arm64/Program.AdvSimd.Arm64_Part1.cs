// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.Arm
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["MaxNumberPairwiseScalar.Vector128.Double"] = MaxNumberPairwiseScalar_Vector128_Double,
                ["MaxPairwise.Vector128.Byte"] = MaxPairwise_Vector128_Byte,
                ["MaxPairwise.Vector128.Double"] = MaxPairwise_Vector128_Double,
                ["MaxPairwise.Vector128.Int16"] = MaxPairwise_Vector128_Int16,
                ["MaxPairwise.Vector128.Int32"] = MaxPairwise_Vector128_Int32,
                ["MaxPairwise.Vector128.SByte"] = MaxPairwise_Vector128_SByte,
                ["MaxPairwise.Vector128.Single"] = MaxPairwise_Vector128_Single,
                ["MaxPairwise.Vector128.UInt16"] = MaxPairwise_Vector128_UInt16,
                ["MaxPairwise.Vector128.UInt32"] = MaxPairwise_Vector128_UInt32,
                ["MaxPairwiseScalar.Vector64.Single"] = MaxPairwiseScalar_Vector64_Single,
                ["MaxPairwiseScalar.Vector128.Double"] = MaxPairwiseScalar_Vector128_Double,
                ["MaxScalar.Vector64.Double"] = MaxScalar_Vector64_Double,
                ["MaxScalar.Vector64.Single"] = MaxScalar_Vector64_Single,
                ["Min.Vector128.Double"] = Min_Vector128_Double,
                ["MinAcross.Vector64.Byte"] = MinAcross_Vector64_Byte,
                ["MinAcross.Vector64.Int16"] = MinAcross_Vector64_Int16,
                ["MinAcross.Vector64.SByte"] = MinAcross_Vector64_SByte,
                ["MinAcross.Vector64.UInt16"] = MinAcross_Vector64_UInt16,
                ["MinAcross.Vector128.Byte"] = MinAcross_Vector128_Byte,
                ["MinAcross.Vector128.Int16"] = MinAcross_Vector128_Int16,
                ["MinAcross.Vector128.Int32"] = MinAcross_Vector128_Int32,
                ["MinAcross.Vector128.SByte"] = MinAcross_Vector128_SByte,
                ["MinAcross.Vector128.Single"] = MinAcross_Vector128_Single,
                ["MinAcross.Vector128.UInt16"] = MinAcross_Vector128_UInt16,
                ["MinAcross.Vector128.UInt32"] = MinAcross_Vector128_UInt32,
                ["MinNumber.Vector128.Double"] = MinNumber_Vector128_Double,
                ["MinNumberAcross.Vector128.Single"] = MinNumberAcross_Vector128_Single,
                ["MinNumberPairwise.Vector64.Single"] = MinNumberPairwise_Vector64_Single,
                ["MinNumberPairwise.Vector128.Double"] = MinNumberPairwise_Vector128_Double,
                ["MinNumberPairwise.Vector128.Single"] = MinNumberPairwise_Vector128_Single,
                ["MinNumberPairwiseScalar.Vector64.Single"] = MinNumberPairwiseScalar_Vector64_Single,
                ["MinNumberPairwiseScalar.Vector128.Double"] = MinNumberPairwiseScalar_Vector128_Double,
                ["MinPairwise.Vector128.Byte"] = MinPairwise_Vector128_Byte,
                ["MinPairwise.Vector128.Double"] = MinPairwise_Vector128_Double,
                ["MinPairwise.Vector128.Int16"] = MinPairwise_Vector128_Int16,
                ["MinPairwise.Vector128.Int32"] = MinPairwise_Vector128_Int32,
                ["MinPairwise.Vector128.SByte"] = MinPairwise_Vector128_SByte,
                ["MinPairwise.Vector128.Single"] = MinPairwise_Vector128_Single,
                ["MinPairwise.Vector128.UInt16"] = MinPairwise_Vector128_UInt16,
                ["MinPairwise.Vector128.UInt32"] = MinPairwise_Vector128_UInt32,
                ["MinPairwiseScalar.Vector64.Single"] = MinPairwiseScalar_Vector64_Single,
                ["MinPairwiseScalar.Vector128.Double"] = MinPairwiseScalar_Vector128_Double,
                ["MinScalar.Vector64.Double"] = MinScalar_Vector64_Double,
                ["MinScalar.Vector64.Single"] = MinScalar_Vector64_Single,
                ["Multiply.Vector128.Double"] = Multiply_Vector128_Double,
                ["MultiplyByScalar.Vector128.Double"] = MultiplyByScalar_Vector128_Double,
                ["MultiplyBySelectedScalar.Vector128.Double.Vector128.Double.1"] = MultiplyBySelectedScalar_Vector128_Double_Vector128_Double_1,
                ["MultiplyDoublingSaturateHighScalar.Vector64.Int16"] = MultiplyDoublingSaturateHighScalar_Vector64_Int16,
                ["MultiplyDoublingSaturateHighScalar.Vector64.Int32"] = MultiplyDoublingSaturateHighScalar_Vector64_Int32,
                ["MultiplyDoublingScalarBySelectedScalarSaturateHigh.Vector64.Int16.Vector64.Int16.3"] = MultiplyDoublingScalarBySelectedScalarSaturateHigh_Vector64_Int16_Vector64_Int16_3,
                ["MultiplyDoublingScalarBySelectedScalarSaturateHigh.Vector64.Int16.Vector128.Int16.7"] = MultiplyDoublingScalarBySelectedScalarSaturateHigh_Vector64_Int16_Vector128_Int16_7,
                ["MultiplyDoublingScalarBySelectedScalarSaturateHigh.Vector64.Int32.Vector64.Int32.1"] = MultiplyDoublingScalarBySelectedScalarSaturateHigh_Vector64_Int32_Vector64_Int32_1,
                ["MultiplyDoublingScalarBySelectedScalarSaturateHigh.Vector64.Int32.Vector128.Int32.3"] = MultiplyDoublingScalarBySelectedScalarSaturateHigh_Vector64_Int32_Vector128_Int32_3,
                ["MultiplyDoublingWideningAndAddSaturateScalar.Vector64.Int16"] = MultiplyDoublingWideningAndAddSaturateScalar_Vector64_Int16,
                ["MultiplyDoublingWideningAndAddSaturateScalar.Vector64.Int32"] = MultiplyDoublingWideningAndAddSaturateScalar_Vector64_Int32,
                ["MultiplyDoublingWideningAndSubtractSaturateScalar.Vector64.Int16"] = MultiplyDoublingWideningAndSubtractSaturateScalar_Vector64_Int16,
                ["MultiplyDoublingWideningAndSubtractSaturateScalar.Vector64.Int32"] = MultiplyDoublingWideningAndSubtractSaturateScalar_Vector64_Int32,
                ["MultiplyDoublingWideningSaturateScalar.Vector64.Int16"] = MultiplyDoublingWideningSaturateScalar_Vector64_Int16,
                ["MultiplyDoublingWideningSaturateScalar.Vector64.Int32"] = MultiplyDoublingWideningSaturateScalar_Vector64_Int32,
                ["MultiplyDoublingWideningSaturateScalarBySelectedScalar.Vector64.Int16.Vector64.Int16.3"] = MultiplyDoublingWideningSaturateScalarBySelectedScalar_Vector64_Int16_Vector64_Int16_3,
                ["MultiplyDoublingWideningSaturateScalarBySelectedScalar.Vector64.Int16.Vector128.Int16.7"] = MultiplyDoublingWideningSaturateScalarBySelectedScalar_Vector64_Int16_Vector128_Int16_7,
                ["MultiplyDoublingWideningSaturateScalarBySelectedScalar.Vector64.Int32.Vector64.Int32.1"] = MultiplyDoublingWideningSaturateScalarBySelectedScalar_Vector64_Int32_Vector64_Int32_1,
                ["MultiplyDoublingWideningSaturateScalarBySelectedScalar.Vector64.Int32.Vector128.Int32.3"] = MultiplyDoublingWideningSaturateScalarBySelectedScalar_Vector64_Int32_Vector128_Int32_3,
                ["MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate.Vector64.Int16.Vector64.Int16.3"] = MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate_Vector64_Int16_Vector64_Int16_3,
                ["MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate.Vector64.Int16.Vector128.Int16.7"] = MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate_Vector64_Int16_Vector128_Int16_7,
                ["MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate.Vector64.Int32.Vector64.Int32.1"] = MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate_Vector64_Int32_Vector64_Int32_1,
                ["MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate.Vector64.Int32.Vector128.Int32.3"] = MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate_Vector64_Int32_Vector128_Int32_3,
                ["MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate.Vector64.Int16.Vector64.Int16.3"] = MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate_Vector64_Int16_Vector64_Int16_3,
                ["MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate.Vector64.Int16.Vector128.Int16.7"] = MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate_Vector64_Int16_Vector128_Int16_7,
                ["MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate.Vector64.Int32.Vector64.Int32.1"] = MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate_Vector64_Int32_Vector64_Int32_1,
                ["MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate.Vector64.Int32.Vector128.Int32.3"] = MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate_Vector64_Int32_Vector128_Int32_3,
                ["MultiplyExtended.Vector64.Single"] = MultiplyExtended_Vector64_Single,
                ["MultiplyExtended.Vector128.Double"] = MultiplyExtended_Vector128_Double,
                ["MultiplyExtended.Vector128.Single"] = MultiplyExtended_Vector128_Single,
                ["MultiplyExtendedByScalar.Vector128.Double"] = MultiplyExtendedByScalar_Vector128_Double,
                ["MultiplyExtendedBySelectedScalar.Vector128.Double.Vector128.Double.1"] = MultiplyExtendedBySelectedScalar_Vector128_Double_Vector128_Double_1,
                ["MultiplyExtendedScalar.Vector64.Double"] = MultiplyExtendedScalar_Vector64_Double,
                ["MultiplyExtendedScalar.Vector64.Single"] = MultiplyExtendedScalar_Vector64_Single,
                ["MultiplyExtendedScalarBySelectedScalar.Vector64.Double.Vector128.Double.1"] = MultiplyExtendedScalarBySelectedScalar_Vector64_Double_Vector128_Double_1,
                ["MultiplyExtendedScalarBySelectedScalar.Vector64.Single.Vector64.Single.1"] = MultiplyExtendedScalarBySelectedScalar_Vector64_Single_Vector64_Single_1,
                ["MultiplyExtendedScalarBySelectedScalar.Vector64.Single.Vector128.Single.3"] = MultiplyExtendedScalarBySelectedScalar_Vector64_Single_Vector128_Single_3,
                ["MultiplyRoundedDoublingSaturateHighScalar.Vector64.Int16"] = MultiplyRoundedDoublingSaturateHighScalar_Vector64_Int16,
                ["MultiplyRoundedDoublingSaturateHighScalar.Vector64.Int32"] = MultiplyRoundedDoublingSaturateHighScalar_Vector64_Int32,
                ["MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh.Vector64.Int16.Vector64.Int16.3"] = MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh_Vector64_Int16_Vector64_Int16_3,
                ["MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh.Vector64.Int16.Vector128.Int16.7"] = MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh_Vector64_Int16_Vector128_Int16_7,
                ["MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh.Vector64.Int32.Vector64.Int32.1"] = MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh_Vector64_Int32_Vector64_Int32_1,
                ["MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh.Vector64.Int32.Vector128.Int32.3"] = MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh_Vector64_Int32_Vector128_Int32_3,
                ["MultiplyScalarBySelectedScalar.Vector64.Double.Vector128.Double.1"] = MultiplyScalarBySelectedScalar_Vector64_Double_Vector128_Double_1,
                ["Negate.Vector128.Double"] = Negate_Vector128_Double,
                ["Negate.Vector128.Int64"] = Negate_Vector128_Int64,
                ["NegateSaturate.Vector128.Int64"] = NegateSaturate_Vector128_Int64,
                ["NegateSaturateScalar.Vector64.Int16"] = NegateSaturateScalar_Vector64_Int16,
                ["NegateSaturateScalar.Vector64.Int32"] = NegateSaturateScalar_Vector64_Int32,
                ["NegateSaturateScalar.Vector64.Int64"] = NegateSaturateScalar_Vector64_Int64,
                ["NegateSaturateScalar.Vector64.SByte"] = NegateSaturateScalar_Vector64_SByte,
                ["NegateScalar.Vector64.Int64"] = NegateScalar_Vector64_Int64,
                ["ReciprocalEstimate.Vector128.Double"] = ReciprocalEstimate_Vector128_Double,
                ["ReciprocalEstimateScalar.Vector64.Double"] = ReciprocalEstimateScalar_Vector64_Double,
                ["ReciprocalEstimateScalar.Vector64.Single"] = ReciprocalEstimateScalar_Vector64_Single,
                ["ReciprocalExponentScalar.Vector64.Double"] = ReciprocalExponentScalar_Vector64_Double,
                ["ReciprocalExponentScalar.Vector64.Single"] = ReciprocalExponentScalar_Vector64_Single,
                ["ReciprocalSquareRootEstimate.Vector128.Double"] = ReciprocalSquareRootEstimate_Vector128_Double,
                ["ReciprocalSquareRootEstimateScalar.Vector64.Double"] = ReciprocalSquareRootEstimateScalar_Vector64_Double,
                ["ReciprocalSquareRootEstimateScalar.Vector64.Single"] = ReciprocalSquareRootEstimateScalar_Vector64_Single,
                ["ReciprocalSquareRootStep.Vector128.Double"] = ReciprocalSquareRootStep_Vector128_Double,
                ["ReciprocalSquareRootStepScalar.Vector64.Double"] = ReciprocalSquareRootStepScalar_Vector64_Double,
                ["ReciprocalSquareRootStepScalar.Vector64.Single"] = ReciprocalSquareRootStepScalar_Vector64_Single,
                ["ReciprocalStep.Vector128.Double"] = ReciprocalStep_Vector128_Double,
                ["ReciprocalStepScalar.Vector64.Double"] = ReciprocalStepScalar_Vector64_Double,
                ["ReciprocalStepScalar.Vector64.Single"] = ReciprocalStepScalar_Vector64_Single,
                ["ReverseElementBits.Vector128.Byte"] = ReverseElementBits_Vector128_Byte,
                ["ReverseElementBits.Vector128.SByte"] = ReverseElementBits_Vector128_SByte,
                ["ReverseElementBits.Vector64.Byte"] = ReverseElementBits_Vector64_Byte,
                ["ReverseElementBits.Vector64.SByte"] = ReverseElementBits_Vector64_SByte,
                ["RoundAwayFromZero.Vector128.Double"] = RoundAwayFromZero_Vector128_Double,
                ["RoundToNearest.Vector128.Double"] = RoundToNearest_Vector128_Double,
                ["RoundToNegativeInfinity.Vector128.Double"] = RoundToNegativeInfinity_Vector128_Double,
                ["RoundToPositiveInfinity.Vector128.Double"] = RoundToPositiveInfinity_Vector128_Double,
                ["RoundToZero.Vector128.Double"] = RoundToZero_Vector128_Double,
                ["ShiftArithmeticRoundedSaturateScalar.Vector64.Int16"] = ShiftArithmeticRoundedSaturateScalar_Vector64_Int16,
                ["ShiftArithmeticRoundedSaturateScalar.Vector64.Int32"] = ShiftArithmeticRoundedSaturateScalar_Vector64_Int32,
                ["ShiftArithmeticRoundedSaturateScalar.Vector64.SByte"] = ShiftArithmeticRoundedSaturateScalar_Vector64_SByte,
                ["ShiftArithmeticSaturateScalar.Vector64.Int16"] = ShiftArithmeticSaturateScalar_Vector64_Int16,
                ["ShiftArithmeticSaturateScalar.Vector64.Int32"] = ShiftArithmeticSaturateScalar_Vector64_Int32,
                ["ShiftArithmeticSaturateScalar.Vector64.SByte"] = ShiftArithmeticSaturateScalar_Vector64_SByte,
                ["ShiftLeftLogicalSaturateScalar.Vector64.Byte.7"] = ShiftLeftLogicalSaturateScalar_Vector64_Byte_7,
                ["ShiftLeftLogicalSaturateScalar.Vector64.Int16.15"] = ShiftLeftLogicalSaturateScalar_Vector64_Int16_15,
                ["ShiftLeftLogicalSaturateScalar.Vector64.Int32.31"] = ShiftLeftLogicalSaturateScalar_Vector64_Int32_31,
                ["ShiftLeftLogicalSaturateScalar.Vector64.SByte.1"] = ShiftLeftLogicalSaturateScalar_Vector64_SByte_1,
                ["ShiftLeftLogicalSaturateScalar.Vector64.UInt16.1"] = ShiftLeftLogicalSaturateScalar_Vector64_UInt16_1,
                ["ShiftLeftLogicalSaturateScalar.Vector64.UInt32.1"] = ShiftLeftLogicalSaturateScalar_Vector64_UInt32_1,
                ["ShiftLeftLogicalSaturateUnsignedScalar.Vector64.Int16.5"] = ShiftLeftLogicalSaturateUnsignedScalar_Vector64_Int16_5,
                ["ShiftLeftLogicalSaturateUnsignedScalar.Vector64.Int32.7"] = ShiftLeftLogicalSaturateUnsignedScalar_Vector64_Int32_7,
                ["ShiftLeftLogicalSaturateUnsignedScalar.Vector64.SByte.3"] = ShiftLeftLogicalSaturateUnsignedScalar_Vector64_SByte_3,
                ["ShiftLogicalRoundedSaturateScalar.Vector64.Byte"] = ShiftLogicalRoundedSaturateScalar_Vector64_Byte,
                ["ShiftLogicalRoundedSaturateScalar.Vector64.Int16"] = ShiftLogicalRoundedSaturateScalar_Vector64_Int16,
                ["ShiftLogicalRoundedSaturateScalar.Vector64.Int32"] = ShiftLogicalRoundedSaturateScalar_Vector64_Int32,
                ["ShiftLogicalRoundedSaturateScalar.Vector64.SByte"] = ShiftLogicalRoundedSaturateScalar_Vector64_SByte,
                ["ShiftLogicalRoundedSaturateScalar.Vector64.UInt16"] = ShiftLogicalRoundedSaturateScalar_Vector64_UInt16,
                ["ShiftLogicalRoundedSaturateScalar.Vector64.UInt32"] = ShiftLogicalRoundedSaturateScalar_Vector64_UInt32,
                ["ShiftLogicalSaturateScalar.Vector64.Byte"] = ShiftLogicalSaturateScalar_Vector64_Byte,
                ["ShiftLogicalSaturateScalar.Vector64.Int16"] = ShiftLogicalSaturateScalar_Vector64_Int16,
                ["ShiftLogicalSaturateScalar.Vector64.Int32"] = ShiftLogicalSaturateScalar_Vector64_Int32,
                ["ShiftLogicalSaturateScalar.Vector64.SByte"] = ShiftLogicalSaturateScalar_Vector64_SByte,
                ["ShiftLogicalSaturateScalar.Vector64.UInt16"] = ShiftLogicalSaturateScalar_Vector64_UInt16,
                ["ShiftLogicalSaturateScalar.Vector64.UInt32"] = ShiftLogicalSaturateScalar_Vector64_UInt32,
                ["ShiftRightArithmeticNarrowingSaturateScalar.Vector64.Int16.16"] = ShiftRightArithmeticNarrowingSaturateScalar_Vector64_Int16_16,
                ["ShiftRightArithmeticNarrowingSaturateScalar.Vector64.Int32.32"] = ShiftRightArithmeticNarrowingSaturateScalar_Vector64_Int32_32,
                ["ShiftRightArithmeticNarrowingSaturateScalar.Vector64.SByte.8"] = ShiftRightArithmeticNarrowingSaturateScalar_Vector64_SByte_8,
                ["ShiftRightArithmeticNarrowingSaturateUnsignedScalar.Vector64.Byte.3"] = ShiftRightArithmeticNarrowingSaturateUnsignedScalar_Vector64_Byte_3,
                ["ShiftRightArithmeticNarrowingSaturateUnsignedScalar.Vector64.UInt16.5"] = ShiftRightArithmeticNarrowingSaturateUnsignedScalar_Vector64_UInt16_5,
                ["ShiftRightArithmeticNarrowingSaturateUnsignedScalar.Vector64.UInt32.7"] = ShiftRightArithmeticNarrowingSaturateUnsignedScalar_Vector64_UInt32_7,
                ["ShiftRightArithmeticRoundedNarrowingSaturateScalar.Vector64.Int16.32"] = ShiftRightArithmeticRoundedNarrowingSaturateScalar_Vector64_Int16_32,
                ["ShiftRightArithmeticRoundedNarrowingSaturateScalar.Vector64.Int32.64"] = ShiftRightArithmeticRoundedNarrowingSaturateScalar_Vector64_Int32_64,
                ["ShiftRightArithmeticRoundedNarrowingSaturateScalar.Vector64.SByte.16"] = ShiftRightArithmeticRoundedNarrowingSaturateScalar_Vector64_SByte_16,
                ["ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar.Vector64.Byte.1"] = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar_Vector64_Byte_1,
                ["ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar.Vector64.UInt16.1"] = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar_Vector64_UInt16_1,
                ["ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar.Vector64.UInt32.1"] = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar_Vector64_UInt32_1,
                ["ShiftRightLogicalNarrowingSaturateScalar.Vector64.Byte.5"] = ShiftRightLogicalNarrowingSaturateScalar_Vector64_Byte_5,
                ["ShiftRightLogicalNarrowingSaturateScalar.Vector64.Int16.7"] = ShiftRightLogicalNarrowingSaturateScalar_Vector64_Int16_7,
                ["ShiftRightLogicalNarrowingSaturateScalar.Vector64.Int32.11"] = ShiftRightLogicalNarrowingSaturateScalar_Vector64_Int32_11,
                ["ShiftRightLogicalNarrowingSaturateScalar.Vector64.SByte.3"] = ShiftRightLogicalNarrowingSaturateScalar_Vector64_SByte_3,
                ["ShiftRightLogicalNarrowingSaturateScalar.Vector64.UInt16.5"] = ShiftRightLogicalNarrowingSaturateScalar_Vector64_UInt16_5,
                ["ShiftRightLogicalNarrowingSaturateScalar.Vector64.UInt32.7"] = ShiftRightLogicalNarrowingSaturateScalar_Vector64_UInt32_7,
                ["ShiftRightLogicalRoundedNarrowingSaturateScalar.Vector64.Byte.1"] = ShiftRightLogicalRoundedNarrowingSaturateScalar_Vector64_Byte_1,
                ["ShiftRightLogicalRoundedNarrowingSaturateScalar.Vector64.Int16.1"] = ShiftRightLogicalRoundedNarrowingSaturateScalar_Vector64_Int16_1,
                ["ShiftRightLogicalRoundedNarrowingSaturateScalar.Vector64.Int32.1"] = ShiftRightLogicalRoundedNarrowingSaturateScalar_Vector64_Int32_1,
                ["ShiftRightLogicalRoundedNarrowingSaturateScalar.Vector64.SByte.1"] = ShiftRightLogicalRoundedNarrowingSaturateScalar_Vector64_SByte_1,
                ["ShiftRightLogicalRoundedNarrowingSaturateScalar.Vector64.UInt16.1"] = ShiftRightLogicalRoundedNarrowingSaturateScalar_Vector64_UInt16_1,
                ["ShiftRightLogicalRoundedNarrowingSaturateScalar.Vector64.UInt32.1"] = ShiftRightLogicalRoundedNarrowingSaturateScalar_Vector64_UInt32_1,
                ["Sqrt.Vector64.Single"] = Sqrt_Vector64_Single,
                ["Sqrt.Vector128.Double"] = Sqrt_Vector128_Double,
                ["Sqrt.Vector128.Single"] = Sqrt_Vector128_Single,
                ["Subtract.Vector128.Double"] = Subtract_Vector128_Double,
                ["SubtractSaturateScalar.Vector64.Byte"] = SubtractSaturateScalar_Vector64_Byte,
                ["SubtractSaturateScalar.Vector64.Int16"] = SubtractSaturateScalar_Vector64_Int16,
                ["SubtractSaturateScalar.Vector64.Int32"] = SubtractSaturateScalar_Vector64_Int32,
                ["SubtractSaturateScalar.Vector64.SByte"] = SubtractSaturateScalar_Vector64_SByte,
                ["SubtractSaturateScalar.Vector64.UInt16"] = SubtractSaturateScalar_Vector64_UInt16,
                ["SubtractSaturateScalar.Vector64.UInt32"] = SubtractSaturateScalar_Vector64_UInt32,
                ["TransposeEven.Vector64.Byte"] = TransposeEven_Vector64_Byte,
                ["TransposeEven.Vector64.Int16"] = TransposeEven_Vector64_Int16,
                ["TransposeEven.Vector64.Int32"] = TransposeEven_Vector64_Int32,
                ["TransposeEven.Vector64.SByte"] = TransposeEven_Vector64_SByte,
                ["TransposeEven.Vector64.Single"] = TransposeEven_Vector64_Single,
                ["TransposeEven.Vector64.UInt16"] = TransposeEven_Vector64_UInt16,
                ["TransposeEven.Vector64.UInt32"] = TransposeEven_Vector64_UInt32,
                ["TransposeEven.Vector128.Byte"] = TransposeEven_Vector128_Byte,
                ["TransposeEven.Vector128.Double"] = TransposeEven_Vector128_Double,
                ["TransposeEven.Vector128.Int16"] = TransposeEven_Vector128_Int16,
                ["TransposeEven.Vector128.Int32"] = TransposeEven_Vector128_Int32,
                ["TransposeEven.Vector128.Int64"] = TransposeEven_Vector128_Int64,
                ["TransposeEven.Vector128.SByte"] = TransposeEven_Vector128_SByte,
                ["TransposeEven.Vector128.Single"] = TransposeEven_Vector128_Single,
                ["TransposeEven.Vector128.UInt16"] = TransposeEven_Vector128_UInt16,
                ["TransposeEven.Vector128.UInt32"] = TransposeEven_Vector128_UInt32,
                ["TransposeEven.Vector128.UInt64"] = TransposeEven_Vector128_UInt64,
                ["TransposeOdd.Vector64.Byte"] = TransposeOdd_Vector64_Byte,
                ["TransposeOdd.Vector64.Int16"] = TransposeOdd_Vector64_Int16,
                ["TransposeOdd.Vector64.Int32"] = TransposeOdd_Vector64_Int32,
                ["TransposeOdd.Vector64.SByte"] = TransposeOdd_Vector64_SByte,
                ["TransposeOdd.Vector64.Single"] = TransposeOdd_Vector64_Single,
                ["TransposeOdd.Vector64.UInt16"] = TransposeOdd_Vector64_UInt16,
                ["TransposeOdd.Vector64.UInt32"] = TransposeOdd_Vector64_UInt32,
                ["TransposeOdd.Vector128.Byte"] = TransposeOdd_Vector128_Byte,
                ["TransposeOdd.Vector128.Double"] = TransposeOdd_Vector128_Double,
                ["TransposeOdd.Vector128.Int16"] = TransposeOdd_Vector128_Int16,
                ["TransposeOdd.Vector128.Int32"] = TransposeOdd_Vector128_Int32,
                ["TransposeOdd.Vector128.Int64"] = TransposeOdd_Vector128_Int64,
                ["TransposeOdd.Vector128.SByte"] = TransposeOdd_Vector128_SByte,
                ["TransposeOdd.Vector128.Single"] = TransposeOdd_Vector128_Single,
                ["TransposeOdd.Vector128.UInt16"] = TransposeOdd_Vector128_UInt16,
                ["TransposeOdd.Vector128.UInt32"] = TransposeOdd_Vector128_UInt32,
                ["TransposeOdd.Vector128.UInt64"] = TransposeOdd_Vector128_UInt64,
                ["VectorTableLookup.Vector128.Byte"] = VectorTableLookup_Vector128_Byte,
                ["VectorTableLookup.Vector128.SByte"] = VectorTableLookup_Vector128_SByte,
                ["VectorTableLookupExtension.Vector128.Byte"] = VectorTableLookupExtension_Vector128_Byte,
                ["VectorTableLookupExtension.Vector128.SByte"] = VectorTableLookupExtension_Vector128_SByte,
                ["UnzipEven.Vector64.Byte"] = UnzipEven_Vector64_Byte,
                ["UnzipEven.Vector64.Int16"] = UnzipEven_Vector64_Int16,
                ["UnzipEven.Vector64.Int32"] = UnzipEven_Vector64_Int32,
                ["UnzipEven.Vector64.SByte"] = UnzipEven_Vector64_SByte,
                ["UnzipEven.Vector64.Single"] = UnzipEven_Vector64_Single,
                ["UnzipEven.Vector64.UInt16"] = UnzipEven_Vector64_UInt16,
                ["UnzipEven.Vector64.UInt32"] = UnzipEven_Vector64_UInt32,
                ["UnzipEven.Vector128.Byte"] = UnzipEven_Vector128_Byte,
                ["UnzipEven.Vector128.Double"] = UnzipEven_Vector128_Double,
                ["UnzipEven.Vector128.Int16"] = UnzipEven_Vector128_Int16,
                ["UnzipEven.Vector128.Int32"] = UnzipEven_Vector128_Int32,
                ["UnzipEven.Vector128.Int64"] = UnzipEven_Vector128_Int64,
                ["UnzipEven.Vector128.SByte"] = UnzipEven_Vector128_SByte,
                ["UnzipEven.Vector128.Single"] = UnzipEven_Vector128_Single,
                ["UnzipEven.Vector128.UInt16"] = UnzipEven_Vector128_UInt16,
                ["UnzipEven.Vector128.UInt32"] = UnzipEven_Vector128_UInt32,
                ["UnzipEven.Vector128.UInt64"] = UnzipEven_Vector128_UInt64,
                ["UnzipOdd.Vector64.Byte"] = UnzipOdd_Vector64_Byte,
                ["UnzipOdd.Vector64.Int16"] = UnzipOdd_Vector64_Int16,
                ["UnzipOdd.Vector64.Int32"] = UnzipOdd_Vector64_Int32,
                ["UnzipOdd.Vector64.SByte"] = UnzipOdd_Vector64_SByte,
                ["UnzipOdd.Vector64.Single"] = UnzipOdd_Vector64_Single,
                ["UnzipOdd.Vector64.UInt16"] = UnzipOdd_Vector64_UInt16,
                ["UnzipOdd.Vector64.UInt32"] = UnzipOdd_Vector64_UInt32,
                ["UnzipOdd.Vector128.Byte"] = UnzipOdd_Vector128_Byte,
                ["UnzipOdd.Vector128.Double"] = UnzipOdd_Vector128_Double,
                ["UnzipOdd.Vector128.Int16"] = UnzipOdd_Vector128_Int16,
                ["UnzipOdd.Vector128.Int32"] = UnzipOdd_Vector128_Int32,
                ["UnzipOdd.Vector128.Int64"] = UnzipOdd_Vector128_Int64,
                ["UnzipOdd.Vector128.SByte"] = UnzipOdd_Vector128_SByte,
                ["UnzipOdd.Vector128.Single"] = UnzipOdd_Vector128_Single,
                ["UnzipOdd.Vector128.UInt16"] = UnzipOdd_Vector128_UInt16,
                ["UnzipOdd.Vector128.UInt32"] = UnzipOdd_Vector128_UInt32,
                ["UnzipOdd.Vector128.UInt64"] = UnzipOdd_Vector128_UInt64,
                ["ZipHigh.Vector64.Byte"] = ZipHigh_Vector64_Byte,
                ["ZipHigh.Vector64.Int16"] = ZipHigh_Vector64_Int16,
                ["ZipHigh.Vector64.Int32"] = ZipHigh_Vector64_Int32,
                ["ZipHigh.Vector64.SByte"] = ZipHigh_Vector64_SByte,
            };
        }
    }
}
