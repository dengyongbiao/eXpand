﻿using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace XpandSystemTester.Module.FunctionalTests.HideToolBar {
    [DefaultClassOptions]
    public class HideToolBarObject:BaseObject {
        public HideToolBarObject(Session session) : base(session){
        }

        
        [Association("HideToolBarObject-HideToolBarObjectChilds")]
        public XPCollection<HideToolBarObjectChild> Children{
            get {
                return GetCollection<HideToolBarObjectChild>("Children");
            }
        }
    }

    public class HideToolBarObjectChild:BaseObject {
        public HideToolBarObjectChild(Session session) : base(session){
        }

        
        private HideToolBarObject _hideToolBarObject;

        [Association("HideToolBarObject-HideToolBarObjectChilds")]
        public HideToolBarObject HideToolBarObject {
            get {
                return _hideToolBarObject;
            }
            set {
                SetPropertyValue("HideToolBarObject", ref _hideToolBarObject, value);
            }
        }
    }
}
