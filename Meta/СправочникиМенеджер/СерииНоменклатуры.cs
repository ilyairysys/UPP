
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������//��������
{
	public partial class �����������������:������������������
	{

		public static �����������������.����������������� �����������(decimal ���)
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������]
					,_Fld3401 [�������������]
					,_Fld3402 [������������]
					,_Fld3403RRef [��������]
					,_Fld3404RRef [�������������������]
					,_Fld3405RRef [�������������������]
					,_Fld3406 [�����������]
					From _Reference226(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.�����������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.������������� = �������.GetString(6);
							������.������������ = �������.GetDateTime(7);
							//������.�������� = new V82.�����������������.���������((byte[])�������.GetValue(8));
							//������.������������������� = new V82.�����������������.����������������������((byte[])�������.GetValue(9));
							//������.������������������� = new V82.�����������������.���������������������������������((byte[])�������.GetValue(10));
							������.����������� = �������.GetString(11);
							return ������;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static ������������������.����������������� �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1000 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������],_Fld3401 [�������������],_Fld3402 [������������],_Fld3403RRef [��������],_Fld3404RRef [�������������������],_Fld3405RRef [�������������������],_Fld3406 [�����������]
		 From _Reference226(NOLOCK)";
					var ������� = new V82.������������������.�����������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.�����������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.������������� = �������.GetString(6);
							������.������������ = �������.GetDateTime(7);
							//������.�������� = new V82.�����������������.���������((byte[])�������.GetValue(8));
							//������.������������������� = new V82.�����������������.����������������������((byte[])�������.GetValue(9));
							//������.������������������� = new V82.�����������������.���������������������������������((byte[])�������.GetValue(10));
							������.����������� = �������.GetString(11);
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.����������������� ��������������()
		{
			var ������ = new V82.�����������������.�����������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.������������� = "";
			������.����������� = "";
			������.�������� = new V82.�����������������.���������();
			������.������������������� = new V82.�����������������.����������������������();
			������.������������������� = new V82.�����������������.���������������������������������();
			return ������;
		}
	}
}
