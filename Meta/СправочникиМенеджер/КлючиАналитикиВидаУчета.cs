
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������//��������
{
	public partial class �����������������������:������������������
	{



		public static V82.�����������������.����������������������� ��������������()
		{
			var ������ = new V82.�����������������.�����������������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			return ������;
		}
	}
}
