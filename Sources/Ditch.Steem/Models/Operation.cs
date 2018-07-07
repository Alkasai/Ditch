﻿using System.IO;
using Ditch.Core.Converters;
using Ditch.Core.Interfaces;
using Ditch.Steem.Operations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ditch.Steem.Models
{
    [JsonConverter(typeof(CustomConverter))]
    [JsonObject(MemberSerialization.OptIn)]
    public class Operation : ICustomJson, ICustomSerializer
    {
        private BaseOperation _baseOperation;

        public Operation() { }

        public Operation(BaseOperation baseOperation)
        {
            _baseOperation = baseOperation;
        }


        public static implicit operator BaseOperation(Operation d)
        {
            return d._baseOperation;
        }

        public static implicit operator Operation(BaseOperation baseOperation)
        {
            return new Operation(baseOperation);
        }

        #region ICustomJson


        public void ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartArray)
            {
                var opName = reader.ReadAsString();
                reader.Read();
                switch (opName)
                {
                    case VoteOperation.OperationName:
                        _baseOperation = serializer.Deserialize<VoteOperation>(reader);
                        break;
                    case CommentOperation.OperationName:
                        _baseOperation = serializer.Deserialize<CommentOperation>(reader);
                        break;

                    case TransferOperation.OperationName:
                        _baseOperation = serializer.Deserialize<TransferOperation>(reader);
                        break;
                    case TransferToVestingOperation.OperationName:
                        _baseOperation = serializer.Deserialize<TransferToVestingOperation>(reader);
                        break;
                    case WithdrawVestingOperation.OperationName:
                        _baseOperation = serializer.Deserialize<WithdrawVestingOperation>(reader);
                        break;

                    //LimitOrderCreate,
                    //LimitOrderCancel,

                    //FeedPublish,
                    //Convert,

                    case AccountCreateOperation.OperationName:
                        _baseOperation = serializer.Deserialize<AccountCreateOperation>(reader);
                        break;
                    case AccountUpdateOperation.OperationName:
                        _baseOperation = serializer.Deserialize<AccountUpdateOperation>(reader);
                        break;

                    case WitnessUpdateOperation.OperationName:
                        _baseOperation = serializer.Deserialize<WitnessUpdateOperation>(reader);
                        break;
                    //AccountWitnessVote,
                    //AccountWitnessProxy,

                    //Pow,

                    //Custom,

                    //ReportOverProduction,

                    case DeleteCommentOperation.OperationName:
                        _baseOperation = serializer.Deserialize<DeleteCommentOperation>(reader);
                        break;
                    case CustomJsonOperation.OperationName:
                        _baseOperation = serializer.Deserialize<CustomJsonOperation>(reader);
                        break;
                    case CommentOptionsOperation.OperationName:
                        _baseOperation = serializer.Deserialize<CommentOptionsOperation>(reader);
                        break;
                    //SetWithdrawVestingRoute,
                    //LimitOrderCreate2,
                    //ClaimAccount,
                    //CreateClaimedAccount,
                    //RequestAccountRecovery,
                    //RecoverAccount,
                    //ChangeRecoveryAccount,
                    //EscrowTransfer,
                    //EscrowDispute,
                    //EscrowRelease,
                    //Pow2,
                    //EscrowApprove,
                    //TransferToSavings,
                    //TransferFromSavings,
                    //CancelTransferFromSavings,
                    //CustomBinary,
                    //DeclineVotingRights,
                    //ResetAccount,
                    //SetResetAccount,
                    case ClaimRewardBalanceOperation.OperationName:
                        _baseOperation = serializer.Deserialize<ClaimRewardBalanceOperation>(reader);
                        break;
                    //DelegateVestingShares,
                    //AccountCreateWithDelegation,
                    //WitnessSetProperties,

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
                    //// virtual operations below this point
                    //FillConvertRequest,
                    //AuthorReward,
                    //CurationReward,
                    //CommentReward,
                    //LiquidityReward,
                    //Interest,
                    //FillVestingWithdraw,
                    //FillOrder,
                    //ShutdownWitness,
                    //FillTransferFromSavings,
                    //Hardfork,
                    //CommentPayoutUpdate,
                    //ReturnVestingDelegation,
                    //CommentBenefactorReward,
                    //ProducerReward

                    default:
                        _baseOperation = new UnsupportedOperation(opName, serializer.Deserialize<JObject>(reader));
                        break;
                }

                reader.Read();
            }
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteValue(_baseOperation.TypeName);
            writer.WritePropertyName("value");
            serializer.Serialize(writer, _baseOperation);
            writer.WriteEndObject();
        }

        #endregion

        #region ICustomSerializer

        public void Serializer(Stream stream, IMessageSerializer serializeHelper)
        {
            serializeHelper.AddToMessageStream(stream, _baseOperation.GetType(), _baseOperation);
        }

        #endregion
    }
}