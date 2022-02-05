namespace GuessToNumber.Gateway
{
    public static class SpecificIdentity
    {
        public const uint IdentitySeed = 100;
        public const uint ServerId = IdentitySeed + 1;
        public const uint CreateLobby = 0;
        public const uint JoinLobby = 1;
        public const uint Success = 2;
        public const uint Error = 3;
        public const uint WithMe = 4;
        public const uint WithoutMe = 5;
    }
}
