using System;
using System.Collections.Generic;
using System.Text;

/**
* 命名空间: AnalysisSQL 
* 类 名： JoinTag
* CLR版本： 4.0.30319.42000
* 版本 ：v1.0
* Copyright (c) jinyu  
*/

namespace AnalysisSQL
{
    /// <summary>
    /// 功能描述    ：JoinTag  
    /// 创 建 者    ：jinyu
    /// 创建日期    ：2018/11/9 0:32:34 
    /// 最后修改者  ：jinyu
    /// 最后修改日期：2018/11/9 0:32:34 
    /// </summary>
 
        #region WhereTag

        [TagType(JoinTag.cTagName)]
        [MatchJoinTag]
        internal class JoinTag : SimpleOneWordTag
        {
            #region Consts

            /// <summary>
            /// The name of the tag (its identifier).
            /// </summary>
            public const string cTagName = "JOIN";

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
        }

        #endregion
        #region MatchWhereTagAttribute

        internal class MatchJoinTagAttribute : MatchSimpleOneWordTagAttribute
        {
            #region Properties

            /// <summary>
            /// Gets the name of the tag (its identifier and sql text)
            /// </summary>
            protected override string Name
            {
                get
                {
                    return JoinTag.cTagName;
                }
            }

            #endregion
        }

        #endregion
    
}
