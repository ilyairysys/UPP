
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������//��������
{
	public partial class ��������������:������������������
	{

		public static �����������������.�������������� �����������(decimal ���)
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
					,_Fld2519 [�������]
					,_Fld2520 [���]
					,_Fld2521 [��������]
					,_Fld2522 [������������]
					,_Fld2523 [��������]
					,_Fld2524 [����������������������]
					,_Fld2525 [���������������������������]
					,_Fld2526RRef [�������������������������������������]
					From _Reference133(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.��������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.������� = �������.GetString(6);
							������.��� = �������.GetString(7);
							������.�������� = �������.GetString(8);
							������.������������ = �������.GetDateTime(9);
							������.�������� = �������.GetString(10);
							������.���������������������� = ((byte[])�������.GetValue(11))[0]==1?true:false;
							������.��������������������������� = �������.GetDecimal(12);
							//������.������������������������������������� = new V82.�����������������.������������((byte[])�������.GetValue(13));
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

		public static ������������������.�������������� �������()
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
					,_Description [������������],_Fld2519 [�������],_Fld2520 [���],_Fld2521 [��������],_Fld2522 [������������],_Fld2523 [��������],_Fld2524 [����������������������],_Fld2525 [���������������������������],_Fld2526RRef [�������������������������������������]
		 From _Reference133(NOLOCK)";
					var ������� = new V82.������������������.��������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.��������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.������� = �������.GetString(6);
							������.��� = �������.GetString(7);
							������.�������� = �������.GetString(8);
							������.������������ = �������.GetDateTime(9);
							������.�������� = �������.GetString(10);
							������.���������������������� = ((byte[])�������.GetValue(11))[0]==1?true:false;
							������.��������������������������� = �������.GetDecimal(12);
							//������.������������������������������������� = new V82.�����������������.������������((byte[])�������.GetValue(13));
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.�������������� ��������������()
		{
			var ������ = new V82.�����������������.��������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.������� = "";
			������.��� = "";
			������.�������� = "";
			������.�������� = "";
			������.������������������������������������� = new V82.�����������������.������������();
			return ������;
		}
	}
}
