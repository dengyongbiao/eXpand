﻿using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace SystemTester.Module.Win.FunctionalTests.ApplicationExit{
    [DefaultClassOptions]
    public class ApplicationExitObject:BaseObject {
        public ApplicationExitObject(Session session) : base(session){
        }
    }
}