using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Ibra.ArdaPilot.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
