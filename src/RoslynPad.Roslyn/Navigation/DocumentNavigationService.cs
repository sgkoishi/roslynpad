﻿using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Navigation;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Text;

namespace RoslynPad.Roslyn.Navigation
{
    [ExportWorkspaceService(typeof(IDocumentNavigationService))]
    internal sealed class DocumentNavigationService : IDocumentNavigationService
    {
        public bool CanNavigateToSpan(Workspace workspace, DocumentId documentId, TextSpan textSpan) => true;
        public bool CanNavigateToPosition(Workspace workspace, DocumentId documentId, int position, int virtualSpace = 0) => true;
        public bool TryNavigateToSpan(Workspace workspace, DocumentId documentId, TextSpan textSpan, OptionSet? options = null) => true;
        public bool TryNavigateToLineAndOffset(Workspace workspace, DocumentId documentId, int lineNumber, int offset, OptionSet? options = null) => true;
        public bool TryNavigateToPosition(Workspace workspace, DocumentId documentId, int position, int virtualSpace = 0, OptionSet? options = null) => true;
        public bool CanNavigateToSpan(Workspace workspace, DocumentId documentId, TextSpan textSpan, CancellationToken cancellationToken) => true;
        public bool CanNavigateToLineAndOffset(Workspace workspace, DocumentId documentId, int lineNumber, int offset, CancellationToken cancellationToken) => true;
        public bool CanNavigateToPosition(Workspace workspace, DocumentId documentId, int position, int virtualSpace, CancellationToken cancellationToken) => true;
        public bool TryNavigateToSpan(Workspace workspace, DocumentId documentId, TextSpan textSpan, OptionSet options, bool allowInvalidSpan, CancellationToken cancellationToken) => true;
        public bool TryNavigateToLineAndOffset(Workspace workspace, DocumentId documentId, int lineNumber, int offset, OptionSet options, CancellationToken cancellationToken) => true;
        public bool TryNavigateToPosition(Workspace workspace, DocumentId documentId, int position, int virtualSpace, OptionSet options, CancellationToken cancellationToken) => true;
    }
}
