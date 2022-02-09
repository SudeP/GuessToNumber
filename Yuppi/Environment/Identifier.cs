using System.Collections.Generic;

namespace Yuppi.Environment
{
    public class Identifier
    {
        public Identifier()
        {
            specialIdList = Extensions.ToList<SpecialId>();
        }

        private uint lastNewIdentity = IdentitySeed;

        public const uint IdentitySeed = 100;

        public readonly List<SpecialId> specialIdList;

        public uint GetNewIdentity()
        {
            return ++lastNewIdentity;
        }

        public bool IsCorrect(uint identity)
        {
            return identity > ((int)SpecialId.Server) && uint.MaxValue > identity;
        }
    }
}
