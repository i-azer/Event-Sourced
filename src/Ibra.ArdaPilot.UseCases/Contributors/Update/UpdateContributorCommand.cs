using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Ibra.ArdaPilot.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
