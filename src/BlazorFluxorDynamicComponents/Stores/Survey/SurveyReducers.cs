using Fluxor;

namespace BlazorFluxorDynamicComponents.Stores.Survey;

public static class SurveyReducers
{
    [ReducerMethod(typeof(SurveyNextQuestionAction))]
    public static SurveyState ReduceSurveyNextQuestionAction(SurveyState state)
    {
        var currentType = state.CurrentQuestionType.ToString();

        var typePrefix = currentType.Remove(currentType.Length - 1);
        var questionIdString = currentType.Replace(typePrefix, "");
        var questionId = Convert.ToInt32(questionIdString);

        return new SurveyState(
            Type.GetType($"{typePrefix}{questionId + 1}") ??
            typeof(DynamicComponents.Question1)
        );
    }
}