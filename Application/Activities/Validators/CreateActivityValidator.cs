using Application.Activities.Commands;
using Application.Activities.DTOS;


namespace Application.Activities.Validators;

public class CreateActivityValidator: BaseActivityValidator<CreateActivity.Command, CreateActivityDto>
{
    public CreateActivityValidator() : base(x => x.ActivityDto) {}
}
