﻿using HangmanGameService;
using System.ServiceModel;

namespace HangmanGameService
{
    [ServiceContract(CallbackContract = typeof(IAccountCallback))]
    interface IAccountManager
    {
        [OperationContract]
        void SearchAccount(string email);

        [OperationContract]
        void SearchPlayer(string nickName);
    }

    [ServiceContract]
    interface IAccountCallback
    {

        [OperationContract]
        void AccountResponseAccount(ServiceAccount account);

        [OperationContract]
        void AccountResponsePlayer(ServicePlayer player);
    }
}
