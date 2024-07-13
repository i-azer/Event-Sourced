using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Ibra.ArdaPilot.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
