using System;
using System.Collections.Generic;
using System.Text;

/**
* 命名空间: AnalysisSQL 
* 类 名： OnTag
* CLR版本： 4.0.30319.42000
* 版本 ：v1.0
* Copyright (c) jinyu  
*/

namespace AnalysisSQL
{
    /// <summary>
    /// 功能描述    ：OnTag  
    /// 创 建 者    ：jinyu
    /// 创建日期    ：2018/11/9 10:38:02 
    /// 最后修改者  ：jinyu
    /// 最后修改日期：2018/11/9 10:38:02 
    /// </summary>
    /// 
    [TagType(OnTag.cTagName)]
    [MatchOnTag]
    internal   class OnTag:SimpleOneWordTag
    {
        #region Consts

        /// <summary>
        /// The name of the tag (its identifier).
        /// </summary>
        public const string cTagName = "ON";

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the tag (its identifier and sql text)
        /// </summary>
        protected override string Name
        {
            get
            {
                return cTagName;
            }
        }

        #endregion

        #region MatchWhereTagAttribute

        internal class MatchOnTagAttribute : MatchSimpleOneWordTagAttribute
        {
            #region Properties

            /// <summary>
            /// Gets the name of the tag (its identifier and sql text)
            /// </summary>
            protected override string Name
            {
                get
                {
                    return OnTag.cTagName;
                }
            }

            #endregion
        }

        #endregion
    }
}
