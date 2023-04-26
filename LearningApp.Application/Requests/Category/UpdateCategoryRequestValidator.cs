﻿using FluentValidation;
using LearningApp.Application.Extensions;
using LearningApp.Domain.Common;

namespace LearningApp.Application.Requests.Category
{
    public class UpdateCategoryRequestValidator : AbstractValidator<UpdateCategoryRequest>
    {
        public UpdateCategoryRequestValidator()
        {
            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(40);

            RuleFor(r => r.Description)
                .NotEmpty()
                .MaximumLength(140);

            RuleFor(r => r.IconUrl)
                .NotEmpty()
                .MaximumLength(140);

            RuleFor(r => r.QuestionsPerLesson)
                .NotNull()
                .NotEmpty();

            RuleFor(r => r.LessonsPerLevel)
                .NotNull()
                .NotEmpty();

            RuleFor(r => r.IconUrl)
                .Custom((value, context) =>
                {
                    var isUrlOrEmpty = value!.UrlOrEmpty();
                    if (!isUrlOrEmpty)
                    {
                        context.AddFailure("IconUrl", ValidationMessages.InvalidUrl);
                    }
                });
        }
    }
}
