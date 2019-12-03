﻿namespace AcceptanceTests.Common.Model.User
{
    public class UserAccount
    {
        public string Key { get; set; }
        public string Role { get; set; }
        public string AlternativeEmail { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string CaseRoleName { get; set; }
        public string HearingRoleName { get; set; }
        public string Representee { get; set; }
        public string SolicitorsReference { get; set; }
        public bool DefaultParticipant { get; set; }
    }
}