using System;
using System.Security.Cryptography.X509Certificates;
using Application.Activities.DTOS;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities.Queries;

public class GetComments
{
    public class Query : IRequest<Result<List<CommentDto>>>
    {
        public required string ActivityId { get; set; }
    }

    public class Handler(AppDbContext context, IMapper mapper) : IRequestHandler<Query, Result<List<CommentDto>>>
    {
        public async Task<Result<List<CommentDto>>> Handle(Query request, CancellationToken cancellationToken)
        {
            var comments = await context.Comments
                .Where(x => x.ActivityId == request.ActivityId)
                .OrderBy(x => x.CreatedAt)
                .ProjectTo<CommentDto>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return Result<List<CommentDto>>.Success(comments);
        }
    }


}
