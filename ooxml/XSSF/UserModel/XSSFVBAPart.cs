﻿using NPOI.OpenXml4Net.OPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPOI.XSSF.UserModel
{
    public class XSSFVBAPart : POIXMLDocumentPart
    {

        /**
         * Create a new XSSFVBAPart node
         */
        public XSSFVBAPart() : base()
        {
        }

        /**
         * Construct XSSFVBAPart from a package part
         *
         * @param part the package part holding the VBA data,
         * @param rel  the package relationship holding this part
         */
        public XSSFVBAPart(PackagePart part, PackageRelationship rel)
                : base(part, rel)
        {
            
        }

        /**
         * Like *PictureData, VBA objects store the actual content in the part
         * directly without keeping a copy like all others therefore we need to
         * handle them differently.
         */
        protected internal override void PrepareForCommit()
        {
            // do not clear the part here
        }

    }
}
