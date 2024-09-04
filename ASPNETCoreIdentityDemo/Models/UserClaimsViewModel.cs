﻿namespace ASPNETCoreIdentityDemo.Models
{
    public class UserClaimsViewModel
    {
        public UserClaimsViewModel()
        {
            //To Avoid runtime exception, we are initializing the Claims property
            Claims = new List<UserClaim>();
        }
        public string UserId { get; set; }
        public List<UserClaim> Claims { get; set; }
    }
}
