﻿using System;
using System.Linq.Expressions;
using DevExpress.ExpressApp.Model;
using Xpand.ExpressApp.Logic.NodeUpdaters;
using Xpand.ExpressApp.ModelArtifactState.ActionState.Logic;
using Xpand.ExpressApp.ModelArtifactState.ArtifactState.Model;

namespace Xpand.ExpressApp.ModelArtifactState.ActionState.Model {
    public class ActionStateRulesNodeUpdater :
        LogicRulesNodeUpdater<IActionStateRule, IModelActionStateRule> {
        protected override void SetAttribute(IModelActionStateRule rule,IActionStateRule attribute) {
            rule.Attribute = attribute;
        }

        protected override Expression<Func<IModelApplication, object>> ExecuteExpression() {
            return state => ((IModelApplicationModelArtifactState) state).ModelArtifactState.ConditionalActionState;
        }
    }
}