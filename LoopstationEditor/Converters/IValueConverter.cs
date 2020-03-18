namespace LoopstationEditor.Converters
{
    public interface IValueConverter<TInput, TOutput>
    {
        TOutput Convert(TInput value);
        TInput ConvertBack(TOutput value);
    }
}
