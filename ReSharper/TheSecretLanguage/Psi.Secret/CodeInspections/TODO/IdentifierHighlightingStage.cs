﻿using System.Collections.Generic;
using JetBrains.Application.Settings;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Daemon.UsageChecking;
using JetBrains.Util;

namespace JetBrains.ReSharper.Psi.Secret.CodeInspections
{
  [DaemonStage(StagesBefore = new[] { typeof (SmartResolverStage) }, StagesAfter = new[] { typeof (CollectUsagesStage) })]
  public class IdentifierHighlightingStage : SecretDaemonStageBase
  {
    public override IEnumerable<IDaemonStageProcess> CreateProcess(IDaemonProcess process, IContextBoundSettingsStore settings, DaemonProcessKind processKind)
    {
      if (!this.IsSupported(process.SourceFile))
      {
        return EmptyList<IDaemonStageProcess>.InstanceList;
      }
      return new List<IDaemonStageProcess> { new IdentifierHighlighterProcess(process, settings) };
    }
  }
}