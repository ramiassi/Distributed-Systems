using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceChat
{
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceChat" in code, svc and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceChat : IServiceChat
    {
        public ServiceChat()
        {
            
        }
        private List<UserType> usersList = new List<UserType>() {
                                                            new UserType() { UserName="Rami"},
                                                            new UserType() { UserName="Omar"}
                                                         };
        private List<MessageType> messagesList = new List<MessageType>();

        public List<UserType> GetOnlineUsers()
        {
            try
            {
                var matchedItems = from x in usersList
                                   where x.Online == true
                                   select x;
                return matchedItems.ToList<UserType>();
            }
            catch (Exception)
            {
                return new List<UserType>();
            }
        }

        public UserType GetDataUsingDataContract(UserType user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user is null");
            }
            if (user.Blocked)
            {
                throw new AccessViolationException("User is blocked");
            }
            return user;
        }


        public bool LoginUser(UserType user)
        {
            foreach (UserType useritem in usersList)
            {
                if (!useritem.Blocked && useritem.UserName == user.UserName)
                {
                    useritem.Online = true;
                    return true;
                }
            }
            return false;
        }

        public bool LogoutUser(UserType user)
        {
            //foreach (UserType useritem in usersList)
            //{
            //    if (useritem.UserName == user.UserName)
            //    {
            //        useritem.Online = false;
            //        return true;
            //    }
            //}
            try
            {
                var matchedItems = from x in usersList
                           where x.UserName == user.UserName
                           select x;
                matchedItems.First<UserType>().Online = false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }       
            
        }

        public bool SendMessage(UserType fromUser, UserType toUser, string message)
        {
            try
            {
                messagesList.Add(new MessageType { FromUser = fromUser,
                                                    ToUser = toUser,
                                                    Text = message,
                                                    SubmitDate = DateTime.Now
                                                });
                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }

        public List<MessageType> RecieveMessages(UserType user)
        {
            try
            {
                var matchedItems = from x in messagesList
                                   where x.ToUser.UserName == user.UserName
                                   select x;

                return matchedItems.ToList<MessageType>();
            }
            catch (Exception)
            {
                return null;
            }       
        }

    }
}
