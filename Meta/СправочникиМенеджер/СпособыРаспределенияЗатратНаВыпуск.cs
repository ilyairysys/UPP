
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������//��������
{
	///<summary>
	///(���)
	///</summary>
	public partial class ����������������������������������:������������������
	{

		public static �����������������.���������������������������������� �����������(decimal ���)
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
					,_Fld3740 [�����������]
					,_Fld3741RRef [���������������������������������]
					,_Fld3742RRef [����������������������������������������]
					,_Fld3743RRef [�����������������������]
					,_Fld3744RRef [���������������������������]
					,_Fld3745RRef [������]
					,_Fld3746RRef [�������������]
					,_Fld3747RRef [�����������������������������������������]
					,_Fld3748 [����������������������������������]
					,_Fld3749 [����������������������������������������������]
					,_Fld3750 [�������������������������������������������]
					,_Fld3751 [��������������������������������������]
					,_Fld3752 [�����������������������]
					,_Fld3753 [�������]
					,_Fld3754 [�����������]
					,_Fld3755RRef [�����������������]
					,_Fld3756 [��������������������]
					,_Fld3757 [�����������������]
					,_Fld3758 [���������������������]
					,_Fld3759 [�����������]
					,_Fld3760 [���������������������]
					,_Fld3761RRef [������������]
					,_Fld3762 [��������������������������������]
					,_Fld3763RRef [������������������������]
					,_Fld3764 [��������������]
					,_Fld3765RRef [��������������������]
					From _Reference244(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.����������������������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.����������� = �������.GetString(6);
							������.��������������������������������� = V82.������������/*������*/.����������������������������������.������������.��������((byte[])�������.GetValue(7));
							������.���������������������������������������� = V82.������������/*������*/.������������������������������������������.������������.��������((byte[])�������.GetValue(8));
							������.����������������������� = V82.������������/*������*/.�����������������������.������������.��������((byte[])�������.GetValue(9));
							������.��������������������������� = V82.������������/*������*/.��������������������������������.������������.��������((byte[])�������.GetValue(10));
							//������.������ = new V82.�����������������.�������������������((byte[])�������.GetValue(11));
							//������.������������� = new V82.�����������������.�������������((byte[])�������.GetValue(12));
							//������.����������������������������������������� = new V82.�����������������.����������������������������������((byte[])�������.GetValue(13));
							������.���������������������������������� = ((byte[])�������.GetValue(14))[0]==1?true:false;
							������.���������������������������������������������� = ((byte[])�������.GetValue(15))[0]==1?true:false;
							������.������������������������������������������� = ((byte[])�������.GetValue(16))[0]==1?true:false;
							������.�������������������������������������� = ((byte[])�������.GetValue(17))[0]==1?true:false;
							������.����������������������� = ((byte[])�������.GetValue(18))[0]==1?true:false;
							������.������� = �������.GetDecimal(19);
							������.����������� = �������.GetDecimal(20);
							������.����������������� = V82.������������/*������*/.�����������������.������������.��������((byte[])�������.GetValue(21));
							������.����������������� = ((byte[])�������.GetValue(23))[0]==1?true:false;
							������.��������������������� = ((byte[])�������.GetValue(24))[0]==1?true:false;
							������.����������� = ((byte[])�������.GetValue(25))[0]==1?true:false;
							������.������������ = V82.������������/*������*/.��������������.������������.��������((byte[])�������.GetValue(27));
							������.�������������������������������� = ((byte[])�������.GetValue(28))[0]==1?true:false;
							������.������������������������ = V82.������������/*������*/.������������������������������.������������.��������((byte[])�������.GetValue(29));
							������.�������������� = �������.GetString(30);
							������.�������������������� = V82.������������/*������*/.��������������������.������������.��������((byte[])�������.GetValue(31));
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

		public static ������������������.���������������������������������� �������()
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
					,_Description [������������],_Fld3740 [�����������],_Fld3741RRef [���������������������������������],_Fld3742RRef [����������������������������������������],_Fld3743RRef [�����������������������],_Fld3744RRef [���������������������������],_Fld3745RRef [������],_Fld3746RRef [�������������],_Fld3747RRef [�����������������������������������������],_Fld3748 [����������������������������������],_Fld3749 [����������������������������������������������],_Fld3750 [�������������������������������������������],_Fld3751 [��������������������������������������],_Fld3752 [�����������������������],_Fld3753 [�������],_Fld3754 [�����������],_Fld3755RRef [�����������������],_Fld3756 [��������������������],_Fld3757 [�����������������],_Fld3758 [���������������������],_Fld3759 [�����������],_Fld3760 [���������������������],_Fld3761RRef [������������],_Fld3762 [��������������������������������],_Fld3763RRef [������������������������],_Fld3764 [��������������],_Fld3765RRef [��������������������]
		 From _Reference244(NOLOCK)";
					var ������� = new V82.������������������.����������������������������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.����������������������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.����������� = �������.GetString(6);
							������.��������������������������������� = V82.������������/*������*/.����������������������������������.������������.��������((byte[])�������.GetValue(7));
							������.���������������������������������������� = V82.������������/*������*/.������������������������������������������.������������.��������((byte[])�������.GetValue(8));
							������.����������������������� = V82.������������/*������*/.�����������������������.������������.��������((byte[])�������.GetValue(9));
							������.��������������������������� = V82.������������/*������*/.��������������������������������.������������.��������((byte[])�������.GetValue(10));
							//������.������ = new V82.�����������������.�������������������((byte[])�������.GetValue(11));
							//������.������������� = new V82.�����������������.�������������((byte[])�������.GetValue(12));
							//������.����������������������������������������� = new V82.�����������������.����������������������������������((byte[])�������.GetValue(13));
							������.���������������������������������� = ((byte[])�������.GetValue(14))[0]==1?true:false;
							������.���������������������������������������������� = ((byte[])�������.GetValue(15))[0]==1?true:false;
							������.������������������������������������������� = ((byte[])�������.GetValue(16))[0]==1?true:false;
							������.�������������������������������������� = ((byte[])�������.GetValue(17))[0]==1?true:false;
							������.����������������������� = ((byte[])�������.GetValue(18))[0]==1?true:false;
							������.������� = �������.GetDecimal(19);
							������.����������� = �������.GetDecimal(20);
							������.����������������� = V82.������������/*������*/.�����������������.������������.��������((byte[])�������.GetValue(21));
							������.����������������� = ((byte[])�������.GetValue(23))[0]==1?true:false;
							������.��������������������� = ((byte[])�������.GetValue(24))[0]==1?true:false;
							������.����������� = ((byte[])�������.GetValue(25))[0]==1?true:false;
							������.������������ = V82.������������/*������*/.��������������.������������.��������((byte[])�������.GetValue(27));
							������.�������������������������������� = ((byte[])�������.GetValue(28))[0]==1?true:false;
							������.������������������������ = V82.������������/*������*/.������������������������������.������������.��������((byte[])�������.GetValue(29));
							������.�������������� = �������.GetString(30);
							������.�������������������� = V82.������������/*������*/.��������������������.������������.��������((byte[])�������.GetValue(31));
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.���������������������������������� ��������������()
		{
			var ������ = new V82.�����������������.����������������������������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.����������� = "";
			������.�������������� = "";
			������.��������������������������������� = V82.������������/*������*/.����������������������������������.������������;
			������.���������������������������������������� = V82.������������/*������*/.������������������������������������������.������������;
			������.����������������������� = V82.������������/*������*/.�����������������������.������������;
			������.��������������������������� = V82.������������/*������*/.��������������������������������.������������;
			������.������ = new V82.�����������������.�������������������();
			������.������������� = new V82.�����������������.�������������();
			������.����������������������������������������� = new V82.�����������������.����������������������������������();
			������.����������������� = V82.������������/*������*/.�����������������.������������;
			������.������������ = V82.������������/*������*/.��������������.������������;
			������.������������������������ = V82.������������/*������*/.������������������������������.������������;
			������.�������������������� = V82.������������/*������*/.��������������������.������������;
			return ������;
		}
	}
}
