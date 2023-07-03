public abstract class CharacterStates
{
    protected CharacterController controller;
    public CharacterStates(CharacterController _controller)
    {
        this.controller = _controller;
    }
    public abstract void UpdateState();
}