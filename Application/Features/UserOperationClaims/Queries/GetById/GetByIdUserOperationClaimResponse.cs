﻿namespace Application.Features.UserOperationClaims.Queries.GetById
{
    public class GetByIdUserOperationClaimResponse
    {
        public int Id { get; set; }
        public int BaseUserId { get; set; }
        public int OperationClaimId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}
