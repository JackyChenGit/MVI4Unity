namespace MVI4Unity
{
    /// <summary>
    /// Ԫ���Ű��ˮƽ����-��
    /// </summary>
    public abstract class ListCalculatorAlignmentHorRight : ListCalculatorAlignmentHor
    {
        public override float GetPositionX (float gridWidth , float eleWidth)
        {
            return gridWidth - eleWidth;
        }
    }
}