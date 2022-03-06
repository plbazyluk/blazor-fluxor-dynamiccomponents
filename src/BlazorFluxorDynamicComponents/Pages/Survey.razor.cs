using BlazorFluxorDynamicComponents.Stores.Survey;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorFluxorDynamicComponents.Pages;

public partial class Survey
{
    [Inject] private IState<SurveyState> SurveyState { get; set; }

    [Inject] private IDispatcher Dispatcher { get; set; }

    private void GoToNextQuestion() =>
        Dispatcher.Dispatch(new SurveyNextQuestionAction());
}