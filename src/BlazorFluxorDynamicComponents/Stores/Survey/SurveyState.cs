using Fluxor;

namespace BlazorFluxorDynamicComponents.Stores.Survey;

[FeatureState]
public class SurveyState
{
    public Type CurrentQuestionType { get; }

    private SurveyState() =>
        CurrentQuestionType = typeof(DynamicComponents.Question1);

    public SurveyState(Type questionType) =>
        CurrentQuestionType = questionType;
}