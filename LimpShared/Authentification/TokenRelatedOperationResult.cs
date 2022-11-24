﻿namespace LimpShared.Authentification
{
    public class TokenRelatedOperationResult
    {
        public TokenRelatedOperationResultType ResultType { get; set; }
        public FailureType? FailureType { get; set; }
        public JWTPair? JWTPairPayload { get; set; }
        public string Username { get; set; } = string.Empty;
    }
}
