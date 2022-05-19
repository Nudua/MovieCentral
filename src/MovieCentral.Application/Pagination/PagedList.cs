using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using MovieCentral.Shared;
using MovieCentral.Shared.Utils;

namespace MovieCentral.Application.Pagination;

public sealed class PagedList<TSource>
{
    public static readonly PagedList<TSource> Empty = new(new List<TSource>(), 0, 1, 1);

    public PaginationMetaData MetaData { get; }

    public List<TSource> Items { get; set; }

    private PagedList(List<TSource> items, int count, int pageNumber, int pageSize)
    {
        Items = Guard.ThrowIfNull(items);
        Guard.ThrowIfLessThan(count, 0);
        Guard.ThrowIfLessThan(pageNumber, 1);
        Guard.ThrowIfZeroOrLess(pageSize);

        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        MetaData = new PaginationMetaData(count, pageSize, pageNumber, totalPages);
    }

    // Creates a paged list of TDest (generally the dto class you'd want to map to via automapper) with the specified options
    public static async Task<PagedList<TDest>> CreateAndProjectToAsync<TDest>(IQueryable<TSource> source, int pageNumber, int pageSize, IMapper mapper, CancellationToken cancellationToken = default)
    {
        var count = await source.CountAsync(cancellationToken);

        var items = await source.Skip((pageNumber - 1) * pageSize)
                                .Take(pageSize)
                                .ProjectTo<TDest>(mapper.ConfigurationProvider)
                                .ToListAsync(cancellationToken);

        return new PagedList<TDest>(items, count, pageNumber, pageSize);
    }
}
