using System.Collections.Generic;
using UnityEngine;

namespace MVI4Unity
{
    /// <summary>
    /// �б�Ԫ��
    /// </summary>
    public class ListCalculatorElementVo
    {
        /// <summary>
        /// �ߴ�
        /// </summary>
        public Vector2 size;

        private ListCalculatorElementVo () 
        {

        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public ListCalculatorElementVo Set (float w , float h)
        {
            size.x = w;
            size.y = h;
            return this;
        }

        /// <summary>
        /// ��ǰ����ػ���
        /// </summary>
        readonly static List<ListCalculatorElementVo> _storaged = new List<ListCalculatorElementVo> ();

        /// <summary>
        /// ��ȡʵ��
        /// </summary>
        /// <returns></returns>
        public static ListCalculatorElementVo Pop ()
        {
            ListCalculatorElementVo inst;

            if ( _storaged.Count == 0 )
            {
                inst = new ListCalculatorElementVo ();
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
        public static void Push (ListCalculatorElementVo inst)
        {
            inst.size = Vector2.zero;
            _storaged.Add (inst);
        }
    }
}