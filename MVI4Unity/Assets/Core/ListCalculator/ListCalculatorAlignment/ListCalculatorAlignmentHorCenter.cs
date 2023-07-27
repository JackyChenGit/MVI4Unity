namespace MVI4Unity
{
    /// <summary>
    /// Ԫ���Ű��ˮƽ����-��
    /// </summary>
    public abstract class ListCalculatorAlignmentHorCenter : ListCalculatorAlignmentHor
    {
        public override float GetPositionX (float gridWidth , float eleWidth)
        {
            return ( gridWidth - eleWidth ) / 2;
        }
    }
}