namespace Iterator;

class RadioStation
{
    private float mFrequency { get; set; }

    public RadioStation(float frequency)
    {
        this.mFrequency = frequency;
    }

    public float GetFrequency()
    {
        return mFrequency;
    }
}