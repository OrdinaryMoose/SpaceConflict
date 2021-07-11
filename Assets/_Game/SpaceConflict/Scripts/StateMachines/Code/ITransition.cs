namespace SpaceConflict.StateMachines.Code
{
    public interface ITransition
    {
        IState From { get; set; }
        IState To { get; set; }
        bool Condition();
    }
}