﻿using OBD.NET.Common.DataTypes;

namespace OBD.NET.Common.OBDData
{
    public class CalculatedEngineLoad : AbstractOBDData
    {
        #region Properties & Fields

        public Percent Load => new Percent(A / 2.55, 0, 100);

        #endregion

        #region Constructors

        public CalculatedEngineLoad()
            : base(0x04, 1)
        { }

        #endregion
    }
}
