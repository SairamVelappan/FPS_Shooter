public abstract class CharacterStates
{
    protected PlayerController controller;
    public CharacterStates(PlayerController _controller)
    {
        this.controller = _controller;
    }
    public abstract void UpdateState();
}