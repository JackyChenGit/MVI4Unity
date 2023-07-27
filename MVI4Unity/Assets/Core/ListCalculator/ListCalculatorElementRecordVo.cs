using System.Collections.Generic;
using UnityEngine;

namespace MVI4Unity
{
    /// <summary>
    /// �б�Ԫ�ؼ�¼
    /// </summary>
    public class ListCalculatorElementRecordVo
    {
        /// <summary>
        /// Դ����
        /// </summary>
        public ListCalculatorElementVo ele;

        /// <summary>
        /// ���½ǵ�λ��
        /// </summary>
        public Vector2 leftBottomPos;

        /// <summary>
        /// �Ƿ�Ӧ������
        /// </summary>
        public bool active;

        private ListCalculatorElementRecordVo () { }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public ListCalculatorElementRecordVo Set (ListCalculatorElementVo ele)
        {
            this.ele = ele;
            return this;
        }

        /// <summary>
        /// ��ǰ����ػ���
        /// </summary>
        readonly static List<ListCalculatorElementRecordVo> _storaged = new List<ListCalculatorElementRecordVo> ();

        /// <summary>
        /// ��ȡʵ��
        /// </summary>
        /// <returns></returns>
        public static ListCalculatorElementRecordVo Pop ()
        {
            ListCalculatorElementRecordVo inst;

            if ( _storaged.Count == 0 )
            {
                inst = new ListCalculatorElementRecordVo ();
            }

            else
            {
                inst = _storaged [_storaged.Count - 1];
                _storaged.RemoveAt (_storaged.Count - 1);
            }

            return inst;
        }

        /// <summary>
        /// �洢ʵ��
        /// </summary>
        /// <param name="inst"></param>
        public static void Push (ListCalculatorElementRecordVo inst)
        {
            ListCalculatorElementVo.Push (inst.ele);
            inst.leftBottomPos = Vector2.zero;
            inst.active = false;
            inst.ele = default;
            _storaged.Add (inst);
        }
    }
}