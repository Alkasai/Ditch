﻿namespace Ditch.Steem.Models.Operations
{
    /// <summary>
    /// https://github.com/steemit/steem/blob/master/libraries/protocol/include/steemit/protocol/operations.hpp
    ///  NOTE:  do not change the order of any operations
    /// </summary>
    public enum OperationType : byte
    {
        Vote,
        Comment,

        Transfer,
        TransferToVesting,
        WithdrawVesting,

        LimitOrderCreate,
        LimitOrderCancel,

        FeedPublish,
        Convert,

        AccountCreate,
        AccountUpdate,

        WitnessUpdate,
        AccountWitnessVote,
        AccountWitnessProxy,

        Pow,

        Custom,

        ReportOverProduction,

        DeleteComment,
        CustomJson,
        CommentOptions,
        SetWithdrawVestingRoute,
        LimitOrderCreate2,
        PlaceholderA,               // A new op can go here
        PlaceholderB,               // A new op can go here
        RequestAccountRecovery,
        RecoverAccount,
        ChangeRecoveryAccount,
        EscrowTransfer,
        EscrowDispute,
        EscrowRelease,
        Pow2,
        EscrowApprove,
        TransferToSavings,
        TransferFromSavings,
        CancelTransferFromSavings,
        CustomBinary,
        DeclineVotingRights,
        ResetAccount,
        SetResetAccount,
        ClaimRewardBalance,
        DelegateVestingShares,
        AccountCreateWithDelegation,
        WitnessSetProperties,

        //# ifdef STEEM_ENABLE_SMT
        //        /// SMT operations
        //        ClaimRewardBalance2,

        //        SmtSetup,
        //        SmtCapReveal,
        //        SmtRefund,
        //        SmtSetupEmissions,
        //        SmtSetSetupParameters,
        //        SmtSetRuntimeParameters,
        //        SmtCreate,
        //#endif
        /// virtual operations below this point
        FillConvertRequest,
        AuthorReward,
        CurationReward,
        CommentReward,
        LiquidityReward,
        Interest,
        FillVestingWithdraw,
        FillOrder,
        ShutdownWitness,
        FillTransferFromSavings,
        Hardfork,
        CommentPayoutUpdate,
        ReturnVestingDelegation,
        CommentBenefactorReward,
        ProducerReward
    }
}
