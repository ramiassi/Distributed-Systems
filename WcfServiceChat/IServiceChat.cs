using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceChat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceChat" in both code and config file together.
    [ServiceContract]
    public interface IServiceChat
    {

        [OperationContract]
        List<UserType> GetOnlineUsers();

        [OperationContract]
        bool LoginUser(UserType user);

        [OperationContract]
        bool LogoutUser(UserType user);

        [OperationContract]
        bool SendMessage(UserType fromUser, UserType toUser, string message);

        [OperationContract]
        List<MessageType> RecieveMessages(UserType user);

    }


    // Use a data contract as illustrated in the sample below to add user types to service operations.
    [DataContract]
    public class UserType
    {
        [DataMember]
        public bool Blocked { get; set; }

        [DataMember]
        public bool Online { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }

    [DataContract]
    public class MessageType
    {
        private string _text;
        [DataMember]
        public string Text { 
            get { return string.Format("{0}: ({1}) {2}", FromUser.UserName, SubmitDate.ToString(), _text);}
            set { _text = value; }
        }

        [DataMember]
        public UserType FromUser { get; set; }

        [DataMember]
        public UserType ToUser { get; set; }

        [DataMember]
        public DateTime SubmitDate { get; set; }
    }
}
