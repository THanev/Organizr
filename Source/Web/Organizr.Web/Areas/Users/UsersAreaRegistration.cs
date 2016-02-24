﻿using System.Web.Mvc;

namespace Organizr.Web.Areas.Users
{
    public class UsersAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Users";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DeclineFriendRequest",
                "Decline/{senderId}/{receiverId}",
                new { controller = "FriendRequests", action = "Decline" }
            );

            context.MapRoute(
                "AcceptFriendRequest",
                "Accept/{senderId}/{receiverId}",
                new { controller = "FriendRequests", action = "Accept" }
            );

            context.MapRoute(
                "Users_Profile",
                "Me",
                new { controller = "Profile", action = "Details" }
            );

            context.MapRoute(
                "Users_ProfileEdit",
                "Me/Edit",
                new { controller = "Profile", action = "Edit" }
            );

            context.MapRoute(
                "Users_FriendRequests",
                "Me/FriendRequests",
                new { controller = "FriendRequests", action = "GetFriendRequests" }
            );

            context.MapRoute(
                "SendFriendRequest",
                "SendFriendRequest/{senderId}/{receiverId}",
                new {controller = "FriendRequests", action = "SendFriendRequest" }
            );
        }
    }
}