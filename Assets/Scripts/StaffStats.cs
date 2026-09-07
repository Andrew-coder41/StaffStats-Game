[System.Serializable]
public class StaffStats
{
    public float fortitude; // ต้านทานกายภาพ
    public float prudence;  // ต้านทานจิตใจ / วิจัย
    public float temperance;// ความเร็วและสำเร็จในการทำงาน
    public float justice;   // ความเร็วเคลื่อนที่และต่อสู้

    public void GainExperience(string workType, float amount)
    {
        switch (workType)
        {
            case "Instinct":
                fortitude += amount * 0.1f;
                break;
            case "Insight":
                prudence += amount * 0.1f;
                break;
            case "Attachment":
                temperance += amount * 0.1f;
                break;
            case "Repression":
                justice += amount * 0.1f;
                break;
        }
    }

    public float GetTotalStats()
    {
        return fortitude + prudence + temperance + justice;
    }

    public void Reset()
    {
        fortitude = 0f;
        prudence = 0f;
        temperance = 0f;
        justice = 0f;
    }

    public override string ToString()
    {
        return $"Fortitude: {fortitude:F2} | Prudence: {prudence:F2} | Temperance: {temperance:F2} | Justice: {justice:F2}";
    }
}
