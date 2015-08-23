using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V251.Group;
using NHapi.Model.V251.Message;
using NHapi.Model.V251.Segment;
using NHapi.Model.V251.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V251.Group
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class GroupExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get IN3 Records from ADR_A19_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADR_A19_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADR_A19_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADR_A19_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADR_A19_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADR_A19_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADR_A19_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADR_A19_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADR_A19_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADR_A19_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADR_A19_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this ADR_A19_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADR_A19_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADR_A19_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADR_A19_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADR_A19_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADR_A19_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADR_A19_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to ROL
        /// </summary>
        public static ROL AddROL(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNK1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to NK1
        /// </summary>
        public static NK1 AddNK1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL2 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetROL2Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to ROL2
        /// </summary>
        public static ROL AddROL2(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetDB1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to DB1
        /// </summary>
        public static DB1 AddDB1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to OBX
        /// </summary>
        public static OBX AddOBX(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetAL1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to AL1
        /// </summary>
        public static AL1 AddAL1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetDG1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to DG1
        /// </summary>
        public static DG1 AddDG1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetGT1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to GT1
        /// </summary>
        public static GT1 AddGT1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A01_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A01_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A01_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A01_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A01_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A01_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A01_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A01_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A01_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A01_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A01_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A01_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A01_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A01_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A01_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A01_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A01_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A01_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A03_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A03_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A03_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A03_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A03_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A03_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A03_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A03_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A03_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A03_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A03_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A03_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A03_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A03_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A03_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A03_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A03_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A03_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A05_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A05_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A05_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A05_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A05_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A05_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A05_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A05_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A05_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A05_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A05_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A05_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A05_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A05_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A05_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A05_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A05_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A05_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A06_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A06_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A06_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A06_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A06_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A06_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A06_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A06_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A06_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A06_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A06_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A06_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A06_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A06_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A06_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A06_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A06_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A06_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A16_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A16_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A16_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A16_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A16_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A16_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A16_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A16_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A16_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A16_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A16_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A16_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A16_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A16_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A16_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A16_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A16_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A16_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from BAR_P01_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this BAR_P01_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from BAR_P01_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this BAR_P01_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new BAR_P01_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this BAR_P01_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P01_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P01_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P01_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P01_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P01_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P01_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P01_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P01_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P01_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P01_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P01_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P01_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P01_VISIT
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P01_VISIT message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to DB1
        /// </summary>
        public static DB1 AddDB1(this BAR_P01_VISIT message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetOBXRecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from BAR_P01_VISIT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to OBX
        /// </summary>
        public static OBX AddOBX(this BAR_P01_VISIT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to AL1
        /// </summary>
        public static AL1 AddAL1(this BAR_P01_VISIT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to DG1
        /// </summary>
        public static DG1 AddDG1(this BAR_P01_VISIT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetGT1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<GT1> GetAllGT1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to GT1
        /// </summary>
        public static GT1 AddGT1(this BAR_P01_VISIT message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetNK1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to NK1
        /// </summary>
        public static NK1 AddNK1(this BAR_P01_VISIT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from BAR_P02_PATIENT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P02_PATIENT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P02_PATIENT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P02_PATIENT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new BAR_P02_PATIENT to DB1
        /// </summary>
        public static DB1 AddDB1(this BAR_P02_PATIENT message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from BAR_P05_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this BAR_P05_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from BAR_P05_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this BAR_P05_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new BAR_P05_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this BAR_P05_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P05_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P05_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P05_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P05_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P05_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P05_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P05_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P05_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P05_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P05_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P05_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P05_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P05_VISIT
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P05_VISIT message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to DB1
        /// </summary>
        public static DB1 AddDB1(this BAR_P05_VISIT message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetOBXRecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from BAR_P05_VISIT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to OBX
        /// </summary>
        public static OBX AddOBX(this BAR_P05_VISIT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to AL1
        /// </summary>
        public static AL1 AddAL1(this BAR_P05_VISIT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to DG1
        /// </summary>
        public static DG1 AddDG1(this BAR_P05_VISIT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetGT1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<GT1> GetAllGT1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to GT1
        /// </summary>
        public static GT1 AddGT1(this BAR_P05_VISIT message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetNK1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to NK1
        /// </summary>
        public static NK1 AddNK1(this BAR_P05_VISIT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get BLC Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetBLCRecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("BLCRepetitionsUsed", "GetBLC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BLC Records from BAR_P05_VISIT
        /// </summary>
        public static List<BLC> GetAllBLCRecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<BLC>("BLCRepetitionsUsed", "GetBLC");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to BLC
        /// </summary>
        public static BLC AddBLC(this BAR_P05_VISIT message)
        {
            return message.GetBLC(message.BLCRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P12_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P12_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P12_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P12_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P12_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P12_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from BPS_O29_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this BPS_O29_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BPS_O29_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BPS_O29_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new BPS_O29_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this BPS_O29_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from BPS_O29_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this BPS_O29_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BPS_O29_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BPS_O29_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new BPS_O29_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this BPS_O29_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from BPS_O29_PRODUCT
        /// </summary>
        public static IEnumerable GetNTERecords(this BPS_O29_PRODUCT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BPS_O29_PRODUCT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BPS_O29_PRODUCT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new BPS_O29_PRODUCT to NTE
        /// </summary>
        public static NTE AddNTE(this BPS_O29_PRODUCT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from BPS_O29_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this BPS_O29_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from BPS_O29_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this BPS_O29_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new BPS_O29_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this BPS_O29_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get BPX Records from BRP_O30_ORDER
        /// </summary>
        public static IEnumerable GetBPXRecords(this BRP_O30_ORDER message)
        {
            object[] result = message.GetRecords("BPXRepetitionsUsed", "GetBPX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BPX Records from BRP_O30_ORDER
        /// </summary>
        public static List<BPX> GetAllBPXRecords(this BRP_O30_ORDER message)
        {
            return message.GetAllRecords<BPX>("BPXRepetitionsUsed", "GetBPX");
        }

        /// <summary>
        /// Add a new BRP_O30_ORDER to BPX
        /// </summary>
        public static BPX AddBPX(this BRP_O30_ORDER message)
        {
            return message.GetBPX(message.BPXRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from BRP_O30_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this BRP_O30_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from BRP_O30_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this BRP_O30_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new BRP_O30_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this BRP_O30_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get BTX Records from BRT_O32_ORDER
        /// </summary>
        public static IEnumerable GetBTXRecords(this BRT_O32_ORDER message)
        {
            object[] result = message.GetRecords("BTXRepetitionsUsed", "GetBTX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BTX Records from BRT_O32_ORDER
        /// </summary>
        public static List<BTX> GetAllBTXRecords(this BRT_O32_ORDER message)
        {
            return message.GetAllRecords<BTX>("BTXRepetitionsUsed", "GetBTX");
        }

        /// <summary>
        /// Add a new BRT_O32_ORDER to BTX
        /// </summary>
        public static BTX AddBTX(this BRT_O32_ORDER message)
        {
            return message.GetBTX(message.BTXRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from BRT_O32_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this BRT_O32_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from BRT_O32_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this BRT_O32_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new BRT_O32_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this BRT_O32_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from BTS_O31_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this BTS_O31_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BTS_O31_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BTS_O31_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new BTS_O31_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this BTS_O31_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from BTS_O31_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this BTS_O31_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BTS_O31_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BTS_O31_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new BTS_O31_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this BTS_O31_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from BTS_O31_PRODUCT_STATUS
        /// </summary>
        public static IEnumerable GetNTERecords(this BTS_O31_PRODUCT_STATUS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BTS_O31_PRODUCT_STATUS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BTS_O31_PRODUCT_STATUS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new BTS_O31_PRODUCT_STATUS to NTE
        /// </summary>
        public static NTE AddNTE(this BTS_O31_PRODUCT_STATUS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from BTS_O31_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this BTS_O31_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from BTS_O31_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this BTS_O31_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new BTS_O31_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this BTS_O31_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get CSP Records from CRM_C01_PATIENT
        /// </summary>
        public static IEnumerable GetCSPRecords(this CRM_C01_PATIENT message)
        {
            object[] result = message.GetRecords("CSPRepetitionsUsed", "GetCSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CSP Records from CRM_C01_PATIENT
        /// </summary>
        public static List<CSP> GetAllCSPRecords(this CRM_C01_PATIENT message)
        {
            return message.GetAllRecords<CSP>("CSPRepetitionsUsed", "GetCSP");
        }

        /// <summary>
        /// Add a new CRM_C01_PATIENT to CSP
        /// </summary>
        public static CSP AddCSP(this CRM_C01_PATIENT message)
        {
            return message.GetCSP(message.CSPRepetitionsUsed);
        }

        /// <summary>
        /// Get RXARXR Records from CSU_C09_ORCRXARXR
        /// </summary>
        public static IEnumerable GetRXARXRRecords(this CSU_C09_ORCRXARXR message)
        {
            object[] result = message.GetRecords("RXARXRRepetitionsUsed", "GetRXARXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXARXR Records from CSU_C09_ORCRXARXR
        /// </summary>
        public static List<CSU_C09_RXARXR> GetAllRXARXRRecords(this CSU_C09_ORCRXARXR message)
        {
            return message.GetAllRecords<CSU_C09_RXARXR>("RXARXRRepetitionsUsed", "GetRXARXR");
        }

        /// <summary>
        /// Add a new CSU_C09_ORCRXARXR to RXARXR
        /// </summary>
        public static CSU_C09_RXARXR AddRXARXR(this CSU_C09_ORCRXARXR message)
        {
            return message.GetRXARXR(message.RXARXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from CSU_C09_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this CSU_C09_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from CSU_C09_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this CSU_C09_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new CSU_C09_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this CSU_C09_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get STUDY_PHASE Records from CSU_C09_PATIENT
        /// </summary>
        public static IEnumerable GetSTUDY_PHASERecords(this CSU_C09_PATIENT message)
        {
            object[] result = message.GetRecords("STUDY_PHASERepetitionsUsed", "GetSTUDY_PHASE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_PHASE Records from CSU_C09_PATIENT
        /// </summary>
        public static List<CSU_C09_STUDY_PHASE> GetAllSTUDY_PHASERecords(this CSU_C09_PATIENT message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_PHASE>("STUDY_PHASERepetitionsUsed", "GetSTUDY_PHASE");
        }

        /// <summary>
        /// Add a new CSU_C09_PATIENT to STUDY_PHASE
        /// </summary>
        public static CSU_C09_STUDY_PHASE AddSTUDY_PHASE(this CSU_C09_PATIENT message)
        {
            return message.GetSTUDY_PHASE(message.STUDY_PHASERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from CSU_C09_STUDY_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBXRecords(this CSU_C09_STUDY_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from CSU_C09_STUDY_OBSERVATION
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this CSU_C09_STUDY_OBSERVATION message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_OBSERVATION to OBX
        /// </summary>
        public static OBX AddOBX(this CSU_C09_STUDY_OBSERVATION message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get STUDY_SCHEDULE Records from CSU_C09_STUDY_PHASE
        /// </summary>
        public static IEnumerable GetSTUDY_SCHEDULERecords(this CSU_C09_STUDY_PHASE message)
        {
            object[] result = message.GetRecords("STUDY_SCHEDULERepetitionsUsed", "GetSTUDY_SCHEDULE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_SCHEDULE Records from CSU_C09_STUDY_PHASE
        /// </summary>
        public static List<CSU_C09_STUDY_SCHEDULE> GetAllSTUDY_SCHEDULERecords(this CSU_C09_STUDY_PHASE message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_SCHEDULE>("STUDY_SCHEDULERepetitionsUsed", "GetSTUDY_SCHEDULE");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_PHASE to STUDY_SCHEDULE
        /// </summary>
        public static CSU_C09_STUDY_SCHEDULE AddSTUDY_SCHEDULE(this CSU_C09_STUDY_PHASE message)
        {
            return message.GetSTUDY_SCHEDULE(message.STUDY_SCHEDULERepetitionsUsed);
        }

        /// <summary>
        /// Get STUDY_OBSERVATION Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static IEnumerable GetSTUDY_OBSERVATIONRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            object[] result = message.GetRecords("STUDY_OBSERVATIONRepetitionsUsed", "GetSTUDY_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_OBSERVATION Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static List<CSU_C09_STUDY_OBSERVATION> GetAllSTUDY_OBSERVATIONRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_OBSERVATION>("STUDY_OBSERVATIONRepetitionsUsed", "GetSTUDY_OBSERVATION");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_SCHEDULE to STUDY_OBSERVATION
        /// </summary>
        public static CSU_C09_STUDY_OBSERVATION AddSTUDY_OBSERVATION(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetSTUDY_OBSERVATION(message.STUDY_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get ORCRXARXR Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static IEnumerable GetORCRXARXRRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            object[] result = message.GetRecords("ORCRXARXRRepetitionsUsed", "GetORCRXARXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORCRXARXR Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static List<CSU_C09_ORCRXARXR> GetAllORCRXARXRRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetAllRecords<CSU_C09_ORCRXARXR>("ORCRXARXRRepetitionsUsed", "GetORCRXARXR");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_SCHEDULE to ORCRXARXR
        /// </summary>
        public static CSU_C09_ORCRXARXR AddORCRXARXR(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetORCRXARXR(message.ORCRXARXRRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from CSU_C09_TIMING_QTY
        /// </summary>
        public static IEnumerable GetTQ2Records(this CSU_C09_TIMING_QTY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from CSU_C09_TIMING_QTY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this CSU_C09_TIMING_QTY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new CSU_C09_TIMING_QTY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this CSU_C09_TIMING_QTY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from DFT_P03_FINANCIAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P03_FINANCIAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P03_FINANCIAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P03_FINANCIAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new DFT_P03_FINANCIAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this DFT_P03_FINANCIAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from DFT_P03_FINANCIAL_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P03_FINANCIAL_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P03_FINANCIAL_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P03_FINANCIAL_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new DFT_P03_FINANCIAL_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this DFT_P03_FINANCIAL_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from DFT_P03_FINANCIAL_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P03_FINANCIAL_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P03_FINANCIAL_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P03_FINANCIAL_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new DFT_P03_FINANCIAL_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this DFT_P03_FINANCIAL_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from DFT_P03_FINANCIAL_TIMING_QUANTITY
        /// </summary>
        public static IEnumerable GetTQ2Records(this DFT_P03_FINANCIAL_TIMING_QUANTITY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from DFT_P03_FINANCIAL_TIMING_QUANTITY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this DFT_P03_FINANCIAL_TIMING_QUANTITY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new DFT_P03_FINANCIAL_TIMING_QUANTITY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this DFT_P03_FINANCIAL_TIMING_QUANTITY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from DFT_P03_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this DFT_P03_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from DFT_P03_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this DFT_P03_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new DFT_P03_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this DFT_P03_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from DFT_P03_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P03_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P03_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P03_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new DFT_P03_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this DFT_P03_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from DFT_P03_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P03_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P03_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P03_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new DFT_P03_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this DFT_P03_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from DFT_P03_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P03_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P03_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P03_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new DFT_P03_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this DFT_P03_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from DFT_P03_TIMING_QUANTITY
        /// </summary>
        public static IEnumerable GetTQ2Records(this DFT_P03_TIMING_QUANTITY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from DFT_P03_TIMING_QUANTITY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this DFT_P03_TIMING_QUANTITY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new DFT_P03_TIMING_QUANTITY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this DFT_P03_TIMING_QUANTITY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from DFT_P11_FINANCIAL
        /// </summary>
        public static IEnumerable GetDG1Records(this DFT_P11_FINANCIAL message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from DFT_P11_FINANCIAL
        /// </summary>
        public static List<DG1> GetAllDG1Records(this DFT_P11_FINANCIAL message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new DFT_P11_FINANCIAL to DG1
        /// </summary>
        public static DG1 AddDG1(this DFT_P11_FINANCIAL message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from DFT_P11_FINANCIAL
        /// </summary>
        public static IEnumerable GetGT1Records(this DFT_P11_FINANCIAL message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from DFT_P11_FINANCIAL
        /// </summary>
        public static List<GT1> GetAllGT1Records(this DFT_P11_FINANCIAL message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new DFT_P11_FINANCIAL to GT1
        /// </summary>
        public static GT1 AddGT1(this DFT_P11_FINANCIAL message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from DFT_P11_FINANCIAL_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from DFT_P11_FINANCIAL_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new DFT_P11_FINANCIAL_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from DFT_P11_FINANCIAL_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P11_FINANCIAL_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new DFT_P11_FINANCIAL_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from DFT_P11_FINANCIAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P11_FINANCIAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P11_FINANCIAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P11_FINANCIAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new DFT_P11_FINANCIAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this DFT_P11_FINANCIAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from DFT_P11_FINANCIAL_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P11_FINANCIAL_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P11_FINANCIAL_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P11_FINANCIAL_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new DFT_P11_FINANCIAL_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this DFT_P11_FINANCIAL_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from DFT_P11_FINANCIAL_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P11_FINANCIAL_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P11_FINANCIAL_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P11_FINANCIAL_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new DFT_P11_FINANCIAL_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this DFT_P11_FINANCIAL_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from DFT_P11_FINANCIAL_TIMING_QUANTITY
        /// </summary>
        public static IEnumerable GetTQ2Records(this DFT_P11_FINANCIAL_TIMING_QUANTITY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from DFT_P11_FINANCIAL_TIMING_QUANTITY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this DFT_P11_FINANCIAL_TIMING_QUANTITY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new DFT_P11_FINANCIAL_TIMING_QUANTITY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this DFT_P11_FINANCIAL_TIMING_QUANTITY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from DFT_P11_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this DFT_P11_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from DFT_P11_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this DFT_P11_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new DFT_P11_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this DFT_P11_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from DFT_P11_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P11_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P11_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P11_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new DFT_P11_INSURANCE to ROL
        /// </summary>
        public static ROL AddROL(this DFT_P11_INSURANCE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from DFT_P11_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P11_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P11_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P11_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new DFT_P11_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this DFT_P11_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from DFT_P11_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P11_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P11_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P11_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new DFT_P11_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this DFT_P11_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from DFT_P11_TIMING_QUANTITY
        /// </summary>
        public static IEnumerable GetTQ2Records(this DFT_P11_TIMING_QUANTITY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from DFT_P11_TIMING_QUANTITY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this DFT_P11_TIMING_QUANTITY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new DFT_P11_TIMING_QUANTITY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this DFT_P11_TIMING_QUANTITY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from DOC_T12_RESULT
        /// </summary>
        public static IEnumerable GetOBXRecords(this DOC_T12_RESULT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from DOC_T12_RESULT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this DOC_T12_RESULT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new DOC_T12_RESULT to OBX
        /// </summary>
        public static OBX AddOBX(this DOC_T12_RESULT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get SPM Records from EAC_U07_SPECIMEN_CONTAINER
        /// </summary>
        public static IEnumerable GetSPMRecords(this EAC_U07_SPECIMEN_CONTAINER message)
        {
            object[] result = message.GetRecords("SPMRepetitionsUsed", "GetSPM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPM Records from EAC_U07_SPECIMEN_CONTAINER
        /// </summary>
        public static List<SPM> GetAllSPMRecords(this EAC_U07_SPECIMEN_CONTAINER message)
        {
            return message.GetAllRecords<SPM>("SPMRepetitionsUsed", "GetSPM");
        }

        /// <summary>
        /// Add a new EAC_U07_SPECIMEN_CONTAINER to SPM
        /// </summary>
        public static SPM AddSPM(this EAC_U07_SPECIMEN_CONTAINER message)
        {
            return message.GetSPM(message.SPMRepetitionsUsed);
        }

        /// <summary>
        /// Get SPM Records from EAR_U08_SPECIMEN_CONTAINER
        /// </summary>
        public static IEnumerable GetSPMRecords(this EAR_U08_SPECIMEN_CONTAINER message)
        {
            object[] result = message.GetRecords("SPMRepetitionsUsed", "GetSPM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPM Records from EAR_U08_SPECIMEN_CONTAINER
        /// </summary>
        public static List<SPM> GetAllSPMRecords(this EAR_U08_SPECIMEN_CONTAINER message)
        {
            return message.GetAllRecords<SPM>("SPMRepetitionsUsed", "GetSPM");
        }

        /// <summary>
        /// Add a new EAR_U08_SPECIMEN_CONTAINER to SPM
        /// </summary>
        public static SPM AddSPM(this EAR_U08_SPECIMEN_CONTAINER message)
        {
            return message.GetSPM(message.SPMRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from MDM_T01_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this MDM_T01_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from MDM_T01_COMMON_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this MDM_T01_COMMON_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new MDM_T01_COMMON_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this MDM_T01_COMMON_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from MDM_T01_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this MDM_T01_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from MDM_T01_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this MDM_T01_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new MDM_T01_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this MDM_T01_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from MDM_T02_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this MDM_T02_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from MDM_T02_COMMON_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this MDM_T02_COMMON_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new MDM_T02_COMMON_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this MDM_T02_COMMON_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from MDM_T02_OBXNTE
        /// </summary>
        public static IEnumerable GetNTERecords(this MDM_T02_OBXNTE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from MDM_T02_OBXNTE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this MDM_T02_OBXNTE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new MDM_T02_OBXNTE to NTE
        /// </summary>
        public static NTE AddNTE(this MDM_T02_OBXNTE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from MDM_T02_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this MDM_T02_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from MDM_T02_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this MDM_T02_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new MDM_T02_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this MDM_T02_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get PRA Records from MFN_M02_MF_STAFF
        /// </summary>
        public static IEnumerable GetPRARecords(this MFN_M02_MF_STAFF message)
        {
            object[] result = message.GetRecords("PRARepetitionsUsed", "GetPRA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRA Records from MFN_M02_MF_STAFF
        /// </summary>
        public static List<PRA> GetAllPRARecords(this MFN_M02_MF_STAFF message)
        {
            return message.GetAllRecords<PRA>("PRARepetitionsUsed", "GetPRA");
        }

        /// <summary>
        /// Add a new MFN_M02_MF_STAFF to PRA
        /// </summary>
        public static PRA AddPRA(this MFN_M02_MF_STAFF message)
        {
            return message.GetPRA(message.PRARepetitionsUsed);
        }

        /// <summary>
        /// Get ORG Records from MFN_M02_MF_STAFF
        /// </summary>
        public static IEnumerable GetORGRecords(this MFN_M02_MF_STAFF message)
        {
            object[] result = message.GetRecords("ORGRepetitionsUsed", "GetORG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORG Records from MFN_M02_MF_STAFF
        /// </summary>
        public static List<ORG> GetAllORGRecords(this MFN_M02_MF_STAFF message)
        {
            return message.GetAllRecords<ORG>("ORGRepetitionsUsed", "GetORG");
        }

        /// <summary>
        /// Add a new MFN_M02_MF_STAFF to ORG
        /// </summary>
        public static ORG AddORG(this MFN_M02_MF_STAFF message)
        {
            return message.GetORG(message.ORGRepetitionsUsed);
        }

        /// <summary>
        /// Get AFF Records from MFN_M02_MF_STAFF
        /// </summary>
        public static IEnumerable GetAFFRecords(this MFN_M02_MF_STAFF message)
        {
            object[] result = message.GetRecords("AFFRepetitionsUsed", "GetAFF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AFF Records from MFN_M02_MF_STAFF
        /// </summary>
        public static List<AFF> GetAllAFFRecords(this MFN_M02_MF_STAFF message)
        {
            return message.GetAllRecords<AFF>("AFFRepetitionsUsed", "GetAFF");
        }

        /// <summary>
        /// Add a new MFN_M02_MF_STAFF to AFF
        /// </summary>
        public static AFF AddAFF(this MFN_M02_MF_STAFF message)
        {
            return message.GetAFF(message.AFFRepetitionsUsed);
        }

        /// <summary>
        /// Get LAN Records from MFN_M02_MF_STAFF
        /// </summary>
        public static IEnumerable GetLANRecords(this MFN_M02_MF_STAFF message)
        {
            object[] result = message.GetRecords("LANRepetitionsUsed", "GetLAN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LAN Records from MFN_M02_MF_STAFF
        /// </summary>
        public static List<LAN> GetAllLANRecords(this MFN_M02_MF_STAFF message)
        {
            return message.GetAllRecords<LAN>("LANRepetitionsUsed", "GetLAN");
        }

        /// <summary>
        /// Add a new MFN_M02_MF_STAFF to LAN
        /// </summary>
        public static LAN AddLAN(this MFN_M02_MF_STAFF message)
        {
            return message.GetLAN(message.LANRepetitionsUsed);
        }

        /// <summary>
        /// Get EDU Records from MFN_M02_MF_STAFF
        /// </summary>
        public static IEnumerable GetEDURecords(this MFN_M02_MF_STAFF message)
        {
            object[] result = message.GetRecords("EDURepetitionsUsed", "GetEDU");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EDU Records from MFN_M02_MF_STAFF
        /// </summary>
        public static List<EDU> GetAllEDURecords(this MFN_M02_MF_STAFF message)
        {
            return message.GetAllRecords<EDU>("EDURepetitionsUsed", "GetEDU");
        }

        /// <summary>
        /// Add a new MFN_M02_MF_STAFF to EDU
        /// </summary>
        public static EDU AddEDU(this MFN_M02_MF_STAFF message)
        {
            return message.GetEDU(message.EDURepetitionsUsed);
        }

        /// <summary>
        /// Get CER Records from MFN_M02_MF_STAFF
        /// </summary>
        public static IEnumerable GetCERRecords(this MFN_M02_MF_STAFF message)
        {
            object[] result = message.GetRecords("CERRepetitionsUsed", "GetCER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CER Records from MFN_M02_MF_STAFF
        /// </summary>
        public static List<CER> GetAllCERRecords(this MFN_M02_MF_STAFF message)
        {
            return message.GetAllRecords<CER>("CERRepetitionsUsed", "GetCER");
        }

        /// <summary>
        /// Add a new MFN_M02_MF_STAFF to CER
        /// </summary>
        public static CER AddCER(this MFN_M02_MF_STAFF message)
        {
            return message.GetCER(message.CERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from MFN_M02_MF_STAFF
        /// </summary>
        public static IEnumerable GetNTERecords(this MFN_M02_MF_STAFF message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from MFN_M02_MF_STAFF
        /// </summary>
        public static List<NTE> GetAllNTERecords(this MFN_M02_MF_STAFF message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new MFN_M02_MF_STAFF to NTE
        /// </summary>
        public static NTE AddNTE(this MFN_M02_MF_STAFF message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PRC Records from MFN_M04_MF_CDM
        /// </summary>
        public static IEnumerable GetPRCRecords(this MFN_M04_MF_CDM message)
        {
            object[] result = message.GetRecords("PRCRepetitionsUsed", "GetPRC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRC Records from MFN_M04_MF_CDM
        /// </summary>
        public static List<PRC> GetAllPRCRecords(this MFN_M04_MF_CDM message)
        {
            return message.GetAllRecords<PRC>("PRCRepetitionsUsed", "GetPRC");
        }

        /// <summary>
        /// Add a new MFN_M04_MF_CDM to PRC
        /// </summary>
        public static PRC AddPRC(this MFN_M04_MF_CDM message)
        {
            return message.GetPRC(message.PRCRepetitionsUsed);
        }

        /// <summary>
        /// Get LCH Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetLCHRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOCATION to LCH
        /// </summary>
        public static LCH AddLCH(this MFN_M05_MF_LOCATION message)
        {
            return message.GetLCH(message.LCHRepetitionsUsed);
        }

        /// <summary>
        /// Get LRL Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetLRLRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("LRLRepetitionsUsed", "GetLRL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LRL Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<LRL> GetAllLRLRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<LRL>("LRLRepetitionsUsed", "GetLRL");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOCATION to LRL
        /// </summary>
        public static LRL AddLRL(this MFN_M05_MF_LOCATION message)
        {
            return message.GetLRL(message.LRLRepetitionsUsed);
        }

        /// <summary>
        /// Get MF_LOC_DEPT Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetMF_LOC_DEPTRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("MF_LOC_DEPTRepetitionsUsed", "GetMF_LOC_DEPT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_LOC_DEPT Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<MFN_M05_MF_LOC_DEPT> GetAllMF_LOC_DEPTRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<MFN_M05_MF_LOC_DEPT>("MF_LOC_DEPTRepetitionsUsed", "GetMF_LOC_DEPT");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOCATION to MF_LOC_DEPT
        /// </summary>
        public static MFN_M05_MF_LOC_DEPT AddMF_LOC_DEPT(this MFN_M05_MF_LOCATION message)
        {
            return message.GetMF_LOC_DEPT(message.MF_LOC_DEPTRepetitionsUsed);
        }

        /// <summary>
        /// Get LCH Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static IEnumerable GetLCHRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOC_DEPT to LCH
        /// </summary>
        public static LCH AddLCH(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetLCH(message.LCHRepetitionsUsed);
        }

        /// <summary>
        /// Get LCC Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static IEnumerable GetLCCRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            object[] result = message.GetRecords("LCCRepetitionsUsed", "GetLCC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCC Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static List<LCC> GetAllLCCRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetAllRecords<LCC>("LCCRepetitionsUsed", "GetLCC");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOC_DEPT to LCC
        /// </summary>
        public static LCC AddLCC(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetLCC(message.LCCRepetitionsUsed);
        }

        /// <summary>
        /// Get CM2 Records from MFN_M06_MF_PHASE_SCHED_DETAIL
        /// </summary>
        public static IEnumerable GetCM2Records(this MFN_M06_MF_PHASE_SCHED_DETAIL message)
        {
            object[] result = message.GetRecords("CM2RepetitionsUsed", "GetCM2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CM2 Records from MFN_M06_MF_PHASE_SCHED_DETAIL
        /// </summary>
        public static List<CM2> GetAllCM2Records(this MFN_M06_MF_PHASE_SCHED_DETAIL message)
        {
            return message.GetAllRecords<CM2>("CM2RepetitionsUsed", "GetCM2");
        }

        /// <summary>
        /// Add a new MFN_M06_MF_PHASE_SCHED_DETAIL to CM2
        /// </summary>
        public static CM2 AddCM2(this MFN_M06_MF_PHASE_SCHED_DETAIL message)
        {
            return message.GetCM2(message.CM2RepetitionsUsed);
        }

        /// <summary>
        /// Get CM2 Records from MFN_M07_MF_CLIN_STUDY_SCHED
        /// </summary>
        public static IEnumerable GetCM2Records(this MFN_M07_MF_CLIN_STUDY_SCHED message)
        {
            object[] result = message.GetRecords("CM2RepetitionsUsed", "GetCM2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CM2 Records from MFN_M07_MF_CLIN_STUDY_SCHED
        /// </summary>
        public static List<CM2> GetAllCM2Records(this MFN_M07_MF_CLIN_STUDY_SCHED message)
        {
            return message.GetAllRecords<CM2>("CM2RepetitionsUsed", "GetCM2");
        }

        /// <summary>
        /// Add a new MFN_M07_MF_CLIN_STUDY_SCHED to CM2
        /// </summary>
        public static CM2 AddCM2(this MFN_M07_MF_CLIN_STUDY_SCHED message)
        {
            return message.GetCM2(message.CM2RepetitionsUsed);
        }

        /// <summary>
        /// Get OM4 Records from MFN_M09_MF_TEST_CAT_DETAIL
        /// </summary>
        public static IEnumerable GetOM4Records(this MFN_M09_MF_TEST_CAT_DETAIL message)
        {
            object[] result = message.GetRecords("OM4RepetitionsUsed", "GetOM4");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OM4 Records from MFN_M09_MF_TEST_CAT_DETAIL
        /// </summary>
        public static List<OM4> GetAllOM4Records(this MFN_M09_MF_TEST_CAT_DETAIL message)
        {
            return message.GetAllRecords<OM4>("OM4RepetitionsUsed", "GetOM4");
        }

        /// <summary>
        /// Add a new MFN_M09_MF_TEST_CAT_DETAIL to OM4
        /// </summary>
        public static OM4 AddOM4(this MFN_M09_MF_TEST_CAT_DETAIL message)
        {
            return message.GetOM4(message.OM4RepetitionsUsed);
        }

        /// <summary>
        /// Get OM4 Records from MFN_M10_MF_TEST_BATT_DETAIL
        /// </summary>
        public static IEnumerable GetOM4Records(this MFN_M10_MF_TEST_BATT_DETAIL message)
        {
            object[] result = message.GetRecords("OM4RepetitionsUsed", "GetOM4");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OM4 Records from MFN_M10_MF_TEST_BATT_DETAIL
        /// </summary>
        public static List<OM4> GetAllOM4Records(this MFN_M10_MF_TEST_BATT_DETAIL message)
        {
            return message.GetAllRecords<OM4>("OM4RepetitionsUsed", "GetOM4");
        }

        /// <summary>
        /// Add a new MFN_M10_MF_TEST_BATT_DETAIL to OM4
        /// </summary>
        public static OM4 AddOM4(this MFN_M10_MF_TEST_BATT_DETAIL message)
        {
            return message.GetOM4(message.OM4RepetitionsUsed);
        }

        /// <summary>
        /// Get PRC Records from MFR_M04_MF_QUERY
        /// </summary>
        public static IEnumerable GetPRCRecords(this MFR_M04_MF_QUERY message)
        {
            object[] result = message.GetRecords("PRCRepetitionsUsed", "GetPRC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRC Records from MFR_M04_MF_QUERY
        /// </summary>
        public static List<PRC> GetAllPRCRecords(this MFR_M04_MF_QUERY message)
        {
            return message.GetAllRecords<PRC>("PRCRepetitionsUsed", "GetPRC");
        }

        /// <summary>
        /// Add a new MFR_M04_MF_QUERY to PRC
        /// </summary>
        public static PRC AddPRC(this MFR_M04_MF_QUERY message)
        {
            return message.GetPRC(message.PRCRepetitionsUsed);
        }

        /// <summary>
        /// Get LCH Records from MFR_M05_MF_QUERY
        /// </summary>
        public static IEnumerable GetLCHRecords(this MFR_M05_MF_QUERY message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from MFR_M05_MF_QUERY
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this MFR_M05_MF_QUERY message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Add a new MFR_M05_MF_QUERY to LCH
        /// </summary>
        public static LCH AddLCH(this MFR_M05_MF_QUERY message)
        {
            return message.GetLCH(message.LCHRepetitionsUsed);
        }

        /// <summary>
        /// Get LRL Records from MFR_M05_MF_QUERY
        /// </summary>
        public static IEnumerable GetLRLRecords(this MFR_M05_MF_QUERY message)
        {
            object[] result = message.GetRecords("LRLRepetitionsUsed", "GetLRL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LRL Records from MFR_M05_MF_QUERY
        /// </summary>
        public static List<LRL> GetAllLRLRecords(this MFR_M05_MF_QUERY message)
        {
            return message.GetAllRecords<LRL>("LRLRepetitionsUsed", "GetLRL");
        }

        /// <summary>
        /// Add a new MFR_M05_MF_QUERY to LRL
        /// </summary>
        public static LRL AddLRL(this MFR_M05_MF_QUERY message)
        {
            return message.GetLRL(message.LRLRepetitionsUsed);
        }

        /// <summary>
        /// Get LDP Records from MFR_M05_MF_QUERY
        /// </summary>
        public static IEnumerable GetLDPRecords(this MFR_M05_MF_QUERY message)
        {
            object[] result = message.GetRecords("LDPRepetitionsUsed", "GetLDP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LDP Records from MFR_M05_MF_QUERY
        /// </summary>
        public static List<LDP> GetAllLDPRecords(this MFR_M05_MF_QUERY message)
        {
            return message.GetAllRecords<LDP>("LDPRepetitionsUsed", "GetLDP");
        }

        /// <summary>
        /// Add a new MFR_M05_MF_QUERY to LDP
        /// </summary>
        public static LDP AddLDP(this MFR_M05_MF_QUERY message)
        {
            return message.GetLDP(message.LDPRepetitionsUsed);
        }

        /// <summary>
        /// Get LCH2 Records from MFR_M05_MF_QUERY
        /// </summary>
        public static IEnumerable GetLCH2Records(this MFR_M05_MF_QUERY message)
        {
            object[] result = message.GetRecords("LCH2RepetitionsUsed", "GetLCH2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH2 Records from MFR_M05_MF_QUERY
        /// </summary>
        public static List<LCH> GetAllLCH2Records(this MFR_M05_MF_QUERY message)
        {
            return message.GetAllRecords<LCH>("LCH2RepetitionsUsed", "GetLCH2");
        }

        /// <summary>
        /// Add a new MFR_M05_MF_QUERY to LCH2
        /// </summary>
        public static LCH AddLCH2(this MFR_M05_MF_QUERY message)
        {
            return message.GetLCH2(message.LCH2RepetitionsUsed);
        }

        /// <summary>
        /// Get LCC Records from MFR_M05_MF_QUERY
        /// </summary>
        public static IEnumerable GetLCCRecords(this MFR_M05_MF_QUERY message)
        {
            object[] result = message.GetRecords("LCCRepetitionsUsed", "GetLCC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCC Records from MFR_M05_MF_QUERY
        /// </summary>
        public static List<LCC> GetAllLCCRecords(this MFR_M05_MF_QUERY message)
        {
            return message.GetAllRecords<LCC>("LCCRepetitionsUsed", "GetLCC");
        }

        /// <summary>
        /// Add a new MFR_M05_MF_QUERY to LCC
        /// </summary>
        public static LCC AddLCC(this MFR_M05_MF_QUERY message)
        {
            return message.GetLCC(message.LCCRepetitionsUsed);
        }

        /// <summary>
        /// Get CM1 Records from MFR_M06_MF_QUERY
        /// </summary>
        public static IEnumerable GetCM1Records(this MFR_M06_MF_QUERY message)
        {
            object[] result = message.GetRecords("CM1RepetitionsUsed", "GetCM1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CM1 Records from MFR_M06_MF_QUERY
        /// </summary>
        public static List<CM1> GetAllCM1Records(this MFR_M06_MF_QUERY message)
        {
            return message.GetAllRecords<CM1>("CM1RepetitionsUsed", "GetCM1");
        }

        /// <summary>
        /// Add a new MFR_M06_MF_QUERY to CM1
        /// </summary>
        public static CM1 AddCM1(this MFR_M06_MF_QUERY message)
        {
            return message.GetCM1(message.CM1RepetitionsUsed);
        }

        /// <summary>
        /// Get CM2 Records from MFR_M06_MF_QUERY
        /// </summary>
        public static IEnumerable GetCM2Records(this MFR_M06_MF_QUERY message)
        {
            object[] result = message.GetRecords("CM2RepetitionsUsed", "GetCM2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CM2 Records from MFR_M06_MF_QUERY
        /// </summary>
        public static List<CM2> GetAllCM2Records(this MFR_M06_MF_QUERY message)
        {
            return message.GetAllRecords<CM2>("CM2RepetitionsUsed", "GetCM2");
        }

        /// <summary>
        /// Add a new MFR_M06_MF_QUERY to CM2
        /// </summary>
        public static CM2 AddCM2(this MFR_M06_MF_QUERY message)
        {
            return message.GetCM2(message.CM2RepetitionsUsed);
        }

        /// <summary>
        /// Get CM2 Records from MFR_M07_MF_QUERY
        /// </summary>
        public static IEnumerable GetCM2Records(this MFR_M07_MF_QUERY message)
        {
            object[] result = message.GetRecords("CM2RepetitionsUsed", "GetCM2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CM2 Records from MFR_M07_MF_QUERY
        /// </summary>
        public static List<CM2> GetAllCM2Records(this MFR_M07_MF_QUERY message)
        {
            return message.GetAllRecords<CM2>("CM2RepetitionsUsed", "GetCM2");
        }

        /// <summary>
        /// Add a new MFR_M07_MF_QUERY to CM2
        /// </summary>
        public static CM2 AddCM2(this MFR_M07_MF_QUERY message)
        {
            return message.GetCM2(message.CM2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_APP_STATS
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_APP_STATS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_APP_STATS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_APP_STATS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new NMD_N02_APP_STATS to NTE
        /// </summary>
        public static NTE AddNTE(this NMD_N02_APP_STATS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_APP_STATUS
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_APP_STATUS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_APP_STATUS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_APP_STATUS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new NMD_N02_APP_STATUS to NTE
        /// </summary>
        public static NTE AddNTE(this NMD_N02_APP_STATUS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_CLOCK
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_CLOCK message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_CLOCK
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_CLOCK message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new NMD_N02_CLOCK to NTE
        /// </summary>
        public static NTE AddNTE(this NMD_N02_CLOCK message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTERecords(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT to NTE
        /// </summary>
        public static NTE AddNTE(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE2 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTE2Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTE2RepetitionsUsed", "GetNTE2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE2 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTE2Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTE2RepetitionsUsed", "GetNTE2");
        }

        /// <summary>
        /// Add a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT to NTE2
        /// </summary>
        public static NTE AddNTE2(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetNTE2(message.NTE2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE3 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTE3Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTE3RepetitionsUsed", "GetNTE3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE3 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTE3Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTE3RepetitionsUsed", "GetNTE3");
        }

        /// <summary>
        /// Add a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT to NTE3
        /// </summary>
        public static NTE AddNTE3(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetNTE3(message.NTE3RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMB_O27_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMB_O27_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMB_O27_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMB_O27_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMB_O27_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMB_O27_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMB_O27_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMB_O27_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMB_O27_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMB_O27_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMB_O27_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OMB_O27_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from OMB_O27_ORDER
        /// </summary>
        public static IEnumerable GetDG1Records(this OMB_O27_ORDER message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from OMB_O27_ORDER
        /// </summary>
        public static List<DG1> GetAllDG1Records(this OMB_O27_ORDER message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new OMB_O27_ORDER to DG1
        /// </summary>
        public static DG1 AddDG1(this OMB_O27_ORDER message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from OMB_O27_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OMB_O27_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OMB_O27_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OMB_O27_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new OMB_O27_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this OMB_O27_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMB_O27_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMB_O27_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMB_O27_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMB_O27_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMB_O27_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMB_O27_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMB_O27_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMB_O27_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMB_O27_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMB_O27_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMB_O27_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMB_O27_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMB_O27_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMB_O27_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMB_O27_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMB_O27_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMB_O27_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMB_O27_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get ODS Records from OMD_O03_DIET
        /// </summary>
        public static IEnumerable GetODSRecords(this OMD_O03_DIET message)
        {
            object[] result = message.GetRecords("ODSRepetitionsUsed", "GetODS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODS Records from OMD_O03_DIET
        /// </summary>
        public static List<ODS> GetAllODSRecords(this OMD_O03_DIET message)
        {
            return message.GetAllRecords<ODS>("ODSRepetitionsUsed", "GetODS");
        }

        /// <summary>
        /// Add a new OMD_O03_DIET to ODS
        /// </summary>
        public static ODS AddODS(this OMD_O03_DIET message)
        {
            return message.GetODS(message.ODSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O03_DIET
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03_DIET message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03_DIET
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03_DIET message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O03_DIET to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O03_DIET message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O03_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O03_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O03_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ODT Records from OMD_O03_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetODTRecords(this OMD_O03_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("ODTRepetitionsUsed", "GetODT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODT Records from OMD_O03_ORDER_TRAY
        /// </summary>
        public static List<ODT> GetAllODTRecords(this OMD_O03_ORDER_TRAY message)
        {
            return message.GetAllRecords<ODT>("ODTRepetitionsUsed", "GetODT");
        }

        /// <summary>
        /// Add a new OMD_O03_ORDER_TRAY to ODT
        /// </summary>
        public static ODT AddODT(this OMD_O03_ORDER_TRAY message)
        {
            return message.GetODT(message.ODTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O03_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03_ORDER_TRAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03_ORDER_TRAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O03_ORDER_TRAY to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O03_ORDER_TRAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O03_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O03_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O03_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMD_O03_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMD_O03_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMD_O03_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMD_O03_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMD_O03_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMD_O03_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMD_O03_TIMING_DIET
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMD_O03_TIMING_DIET message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMD_O03_TIMING_DIET
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMD_O03_TIMING_DIET message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMD_O03_TIMING_DIET to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMD_O03_TIMING_DIET message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMD_O03_TIMING_TRAY
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMD_O03_TIMING_TRAY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMD_O03_TIMING_TRAY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMD_O03_TIMING_TRAY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMD_O03_TIMING_TRAY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMD_O03_TIMING_TRAY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OMG_O19_CONTAINER
        /// </summary>
        public static IEnumerable GetOBXRecords(this OMG_O19_CONTAINER message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OMG_O19_CONTAINER
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OMG_O19_CONTAINER message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OMG_O19_CONTAINER to OBX
        /// </summary>
        public static OBX AddOBX(this OMG_O19_CONTAINER message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMG_O19_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMG_O19_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_OBSERVATION_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_OBSERVATION_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_OBSERVATION_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_OBSERVATION_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMG_O19_OBSERVATION_PRIOR to NTE
        /// </summary>
        public static NTE AddNTE(this OMG_O19_OBSERVATION_PRIOR message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMG_O19_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OMG_O19_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetDG1Records(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from OMG_O19_ORDER
        /// </summary>
        public static List<DG1> GetAllDG1Records(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new OMG_O19_ORDER to DG1
        /// </summary>
        public static DG1 AddDG1(this OMG_O19_ORDER message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OMG_O19_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new OMG_O19_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this OMG_O19_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OMG_O19_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OMG_O19_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this OMG_O19_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_ORDER_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_ORDER_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMG_O19_ORDER_PRIOR to NTE
        /// </summary>
        public static NTE AddNTE(this OMG_O19_ORDER_PRIOR message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION_PRIOR Records from OMG_O19_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetOBSERVATION_PRIORRecords(this OMG_O19_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION_PRIOR Records from OMG_O19_ORDER_PRIOR
        /// </summary>
        public static List<OMG_O19_OBSERVATION_PRIOR> GetAllOBSERVATION_PRIORRecords(this OMG_O19_ORDER_PRIOR message)
        {
            return message.GetAllRecords<OMG_O19_OBSERVATION_PRIOR>("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");
        }

        /// <summary>
        /// Add a new OMG_O19_ORDER_PRIOR to OBSERVATION_PRIOR
        /// </summary>
        public static OMG_O19_OBSERVATION_PRIOR AddOBSERVATION_PRIOR(this OMG_O19_ORDER_PRIOR message)
        {
            return message.GetOBSERVATION_PRIOR(message.OBSERVATION_PRIORRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMG_O19_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMG_O19_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from OMG_O19_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this OMG_O19_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from OMG_O19_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this OMG_O19_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new OMG_O19_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this OMG_O19_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMG_O19_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMG_O19_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMG_O19_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMG_O19_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMG_O19_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMG_O19_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMG_O19_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMG_O19_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMG_O19_PRIOR_RESULT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMG_O19_PRIOR_RESULT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMG_O19_PRIOR_RESULT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMG_O19_PRIOR_RESULT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_PRIOR Records from OMG_O19_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetORDER_PRIORRecords(this OMG_O19_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_PRIOR Records from OMG_O19_PRIOR_RESULT
        /// </summary>
        public static List<OMG_O19_ORDER_PRIOR> GetAllORDER_PRIORRecords(this OMG_O19_PRIOR_RESULT message)
        {
            return message.GetAllRecords<OMG_O19_ORDER_PRIOR>("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");
        }

        /// <summary>
        /// Add a new OMG_O19_PRIOR_RESULT to ORDER_PRIOR
        /// </summary>
        public static OMG_O19_ORDER_PRIOR AddORDER_PRIOR(this OMG_O19_PRIOR_RESULT message)
        {
            return message.GetORDER_PRIOR(message.ORDER_PRIORRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OMG_O19_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this OMG_O19_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OMG_O19_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OMG_O19_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OMG_O19_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this OMG_O19_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMG_O19_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMG_O19_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMG_O19_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMG_O19_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMG_O19_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMG_O19_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMG_O19_TIMING_PRIOR
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMG_O19_TIMING_PRIOR message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMG_O19_TIMING_PRIOR
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMG_O19_TIMING_PRIOR message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMG_O19_TIMING_PRIOR to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMG_O19_TIMING_PRIOR message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMI_O23_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMI_O23_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMI_O23_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMI_O23_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMI_O23_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMI_O23_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMI_O23_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMI_O23_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMI_O23_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMI_O23_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMI_O23_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OMI_O23_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from OMI_O23_ORDER
        /// </summary>
        public static IEnumerable GetDG1Records(this OMI_O23_ORDER message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from OMI_O23_ORDER
        /// </summary>
        public static List<DG1> GetAllDG1Records(this OMI_O23_ORDER message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new OMI_O23_ORDER to DG1
        /// </summary>
        public static DG1 AddDG1(this OMI_O23_ORDER message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get IPC Records from OMI_O23_ORDER
        /// </summary>
        public static IEnumerable GetIPCRecords(this OMI_O23_ORDER message)
        {
            object[] result = message.GetRecords("IPCRepetitionsUsed", "GetIPC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IPC Records from OMI_O23_ORDER
        /// </summary>
        public static List<IPC> GetAllIPCRecords(this OMI_O23_ORDER message)
        {
            return message.GetAllRecords<IPC>("IPCRepetitionsUsed", "GetIPC");
        }

        /// <summary>
        /// Add a new OMI_O23_ORDER to IPC
        /// </summary>
        public static IPC AddIPC(this OMI_O23_ORDER message)
        {
            return message.GetIPC(message.IPCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMI_O23_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMI_O23_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMI_O23_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMI_O23_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMI_O23_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMI_O23_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMI_O23_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMI_O23_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMI_O23_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMI_O23_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMI_O23_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMI_O23_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMI_O23_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMI_O23_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMI_O23_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMI_O23_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMI_O23_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMI_O23_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OML_O21_CONTAINER
        /// </summary>
        public static IEnumerable GetOBXRecords(this OML_O21_CONTAINER message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OML_O21_CONTAINER
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OML_O21_CONTAINER message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OML_O21_CONTAINER to OBX
        /// </summary>
        public static OBX AddOBX(this OML_O21_CONTAINER message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O21_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O21_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O21_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O21_OBSERVATION_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_OBSERVATION_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_OBSERVATION_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_OBSERVATION_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O21_OBSERVATION_PRIOR to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O21_OBSERVATION_PRIOR message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O21_OBSERVATION_REQUEST to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetDG1Records(this OML_O21_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static List<DG1> GetAllDG1Records(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new OML_O21_OBSERVATION_REQUEST to DG1
        /// </summary>
        public static DG1 AddDG1(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from OML_O21_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OML_O21_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OML_O21_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OML_O21_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new OML_O21_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this OML_O21_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OML_O21_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OML_O21_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OML_O21_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OML_O21_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OML_O21_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this OML_O21_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O21_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_ORDER_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_ORDER_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O21_ORDER_PRIOR to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O21_ORDER_PRIOR message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION_PRIOR Records from OML_O21_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetOBSERVATION_PRIORRecords(this OML_O21_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION_PRIOR Records from OML_O21_ORDER_PRIOR
        /// </summary>
        public static List<OML_O21_OBSERVATION_PRIOR> GetAllOBSERVATION_PRIORRecords(this OML_O21_ORDER_PRIOR message)
        {
            return message.GetAllRecords<OML_O21_OBSERVATION_PRIOR>("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");
        }

        /// <summary>
        /// Add a new OML_O21_ORDER_PRIOR to OBSERVATION_PRIOR
        /// </summary>
        public static OML_O21_OBSERVATION_PRIOR AddOBSERVATION_PRIOR(this OML_O21_ORDER_PRIOR message)
        {
            return message.GetOBSERVATION_PRIOR(message.OBSERVATION_PRIORRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O21_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O21_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O21_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from OML_O21_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this OML_O21_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from OML_O21_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this OML_O21_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new OML_O21_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this OML_O21_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OML_O21_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OML_O21_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OML_O21_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OML_O21_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OML_O21_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OML_O21_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OML_O21_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetAL1Records(this OML_O21_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OML_O21_PRIOR_RESULT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OML_O21_PRIOR_RESULT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OML_O21_PRIOR_RESULT to AL1
        /// </summary>
        public static AL1 AddAL1(this OML_O21_PRIOR_RESULT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_PRIOR Records from OML_O21_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetORDER_PRIORRecords(this OML_O21_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_PRIOR Records from OML_O21_PRIOR_RESULT
        /// </summary>
        public static List<OML_O21_ORDER_PRIOR> GetAllORDER_PRIORRecords(this OML_O21_PRIOR_RESULT message)
        {
            return message.GetAllRecords<OML_O21_ORDER_PRIOR>("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");
        }

        /// <summary>
        /// Add a new OML_O21_PRIOR_RESULT to ORDER_PRIOR
        /// </summary>
        public static OML_O21_ORDER_PRIOR AddORDER_PRIOR(this OML_O21_PRIOR_RESULT message)
        {
            return message.GetORDER_PRIOR(message.ORDER_PRIORRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OML_O21_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this OML_O21_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OML_O21_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OML_O21_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OML_O21_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this OML_O21_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OML_O21_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OML_O21_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OML_O21_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OML_O21_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OML_O21_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OML_O21_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OML_O21_TIMING_PRIOR
        /// </summary>
        public static IEnumerable GetTQ2Records(this OML_O21_TIMING_PRIOR message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OML_O21_TIMING_PRIOR
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OML_O21_TIMING_PRIOR message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OML_O21_TIMING_PRIOR to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OML_O21_TIMING_PRIOR message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O33_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O33_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O33_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O33_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O33_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O33_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O33_OBSERVATION_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O33_OBSERVATION_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O33_OBSERVATION_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O33_OBSERVATION_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O33_OBSERVATION_PRIOR to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O33_OBSERVATION_PRIOR message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O33_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O33_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O33_OBSERVATION_REQUEST
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O33_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O33_OBSERVATION_REQUEST to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O33_OBSERVATION_REQUEST message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from OML_O33_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetDG1Records(this OML_O33_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from OML_O33_OBSERVATION_REQUEST
        /// </summary>
        public static List<DG1> GetAllDG1Records(this OML_O33_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new OML_O33_OBSERVATION_REQUEST to DG1
        /// </summary>
        public static DG1 AddDG1(this OML_O33_OBSERVATION_REQUEST message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from OML_O33_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OML_O33_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OML_O33_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OML_O33_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new OML_O33_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this OML_O33_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OML_O33_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OML_O33_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OML_O33_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OML_O33_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OML_O33_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this OML_O33_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O33_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O33_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O33_ORDER_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O33_ORDER_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O33_ORDER_PRIOR to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O33_ORDER_PRIOR message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION_PRIOR Records from OML_O33_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetOBSERVATION_PRIORRecords(this OML_O33_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION_PRIOR Records from OML_O33_ORDER_PRIOR
        /// </summary>
        public static List<OML_O33_OBSERVATION_PRIOR> GetAllOBSERVATION_PRIORRecords(this OML_O33_ORDER_PRIOR message)
        {
            return message.GetAllRecords<OML_O33_OBSERVATION_PRIOR>("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");
        }

        /// <summary>
        /// Add a new OML_O33_ORDER_PRIOR to OBSERVATION_PRIOR
        /// </summary>
        public static OML_O33_OBSERVATION_PRIOR AddOBSERVATION_PRIOR(this OML_O33_ORDER_PRIOR message)
        {
            return message.GetOBSERVATION_PRIOR(message.OBSERVATION_PRIORRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O33_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O33_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O33_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O33_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O33_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O33_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from OML_O33_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this OML_O33_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from OML_O33_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this OML_O33_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new OML_O33_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this OML_O33_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OML_O33_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OML_O33_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OML_O33_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OML_O33_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OML_O33_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OML_O33_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OML_O33_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetAL1Records(this OML_O33_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OML_O33_PRIOR_RESULT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OML_O33_PRIOR_RESULT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OML_O33_PRIOR_RESULT to AL1
        /// </summary>
        public static AL1 AddAL1(this OML_O33_PRIOR_RESULT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_PRIOR Records from OML_O33_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetORDER_PRIORRecords(this OML_O33_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_PRIOR Records from OML_O33_PRIOR_RESULT
        /// </summary>
        public static List<OML_O33_ORDER_PRIOR> GetAllORDER_PRIORRecords(this OML_O33_PRIOR_RESULT message)
        {
            return message.GetAllRecords<OML_O33_ORDER_PRIOR>("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");
        }

        /// <summary>
        /// Add a new OML_O33_PRIOR_RESULT to ORDER_PRIOR
        /// </summary>
        public static OML_O33_ORDER_PRIOR AddORDER_PRIOR(this OML_O33_PRIOR_RESULT message)
        {
            return message.GetORDER_PRIOR(message.ORDER_PRIORRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OML_O33_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this OML_O33_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OML_O33_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OML_O33_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OML_O33_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this OML_O33_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get SAC Records from OML_O33_SPECIMEN
        /// </summary>
        public static IEnumerable GetSACRecords(this OML_O33_SPECIMEN message)
        {
            object[] result = message.GetRecords("SACRepetitionsUsed", "GetSAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SAC Records from OML_O33_SPECIMEN
        /// </summary>
        public static List<SAC> GetAllSACRecords(this OML_O33_SPECIMEN message)
        {
            return message.GetAllRecords<SAC>("SACRepetitionsUsed", "GetSAC");
        }

        /// <summary>
        /// Add a new OML_O33_SPECIMEN to SAC
        /// </summary>
        public static SAC AddSAC(this OML_O33_SPECIMEN message)
        {
            return message.GetSAC(message.SACRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OML_O33_SPECIMEN
        /// </summary>
        public static IEnumerable GetORDERRecords(this OML_O33_SPECIMEN message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OML_O33_SPECIMEN
        /// </summary>
        public static List<OML_O33_ORDER> GetAllORDERRecords(this OML_O33_SPECIMEN message)
        {
            return message.GetAllRecords<OML_O33_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OML_O33_SPECIMEN to ORDER
        /// </summary>
        public static OML_O33_ORDER AddORDER(this OML_O33_SPECIMEN message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OML_O33_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OML_O33_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OML_O33_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OML_O33_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OML_O33_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OML_O33_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OML_O33_TIMING_PRIOR
        /// </summary>
        public static IEnumerable GetTQ2Records(this OML_O33_TIMING_PRIOR message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OML_O33_TIMING_PRIOR
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OML_O33_TIMING_PRIOR message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OML_O33_TIMING_PRIOR to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OML_O33_TIMING_PRIOR message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O35_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O35_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O35_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O35_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O35_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O35_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O35_OBSERVATION_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O35_OBSERVATION_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O35_OBSERVATION_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O35_OBSERVATION_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O35_OBSERVATION_PRIOR to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O35_OBSERVATION_PRIOR message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O35_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O35_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O35_OBSERVATION_REQUEST
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O35_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O35_OBSERVATION_REQUEST to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O35_OBSERVATION_REQUEST message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from OML_O35_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetDG1Records(this OML_O35_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from OML_O35_OBSERVATION_REQUEST
        /// </summary>
        public static List<DG1> GetAllDG1Records(this OML_O35_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new OML_O35_OBSERVATION_REQUEST to DG1
        /// </summary>
        public static DG1 AddDG1(this OML_O35_OBSERVATION_REQUEST message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from OML_O35_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OML_O35_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OML_O35_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OML_O35_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new OML_O35_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this OML_O35_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OML_O35_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OML_O35_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OML_O35_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OML_O35_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OML_O35_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this OML_O35_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O35_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O35_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O35_ORDER_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O35_ORDER_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O35_ORDER_PRIOR to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O35_ORDER_PRIOR message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION_PRIOR Records from OML_O35_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetOBSERVATION_PRIORRecords(this OML_O35_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION_PRIOR Records from OML_O35_ORDER_PRIOR
        /// </summary>
        public static List<OML_O35_OBSERVATION_PRIOR> GetAllOBSERVATION_PRIORRecords(this OML_O35_ORDER_PRIOR message)
        {
            return message.GetAllRecords<OML_O35_OBSERVATION_PRIOR>("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");
        }

        /// <summary>
        /// Add a new OML_O35_ORDER_PRIOR to OBSERVATION_PRIOR
        /// </summary>
        public static OML_O35_OBSERVATION_PRIOR AddOBSERVATION_PRIOR(this OML_O35_ORDER_PRIOR message)
        {
            return message.GetOBSERVATION_PRIOR(message.OBSERVATION_PRIORRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O35_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O35_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O35_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O35_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O35_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O35_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from OML_O35_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this OML_O35_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from OML_O35_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this OML_O35_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new OML_O35_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this OML_O35_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OML_O35_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OML_O35_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OML_O35_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OML_O35_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OML_O35_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OML_O35_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OML_O35_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetAL1Records(this OML_O35_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OML_O35_PRIOR_RESULT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OML_O35_PRIOR_RESULT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OML_O35_PRIOR_RESULT to AL1
        /// </summary>
        public static AL1 AddAL1(this OML_O35_PRIOR_RESULT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_PRIOR Records from OML_O35_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetORDER_PRIORRecords(this OML_O35_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_PRIOR Records from OML_O35_PRIOR_RESULT
        /// </summary>
        public static List<OML_O35_ORDER_PRIOR> GetAllORDER_PRIORRecords(this OML_O35_PRIOR_RESULT message)
        {
            return message.GetAllRecords<OML_O35_ORDER_PRIOR>("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");
        }

        /// <summary>
        /// Add a new OML_O35_PRIOR_RESULT to ORDER_PRIOR
        /// </summary>
        public static OML_O35_ORDER_PRIOR AddORDER_PRIOR(this OML_O35_PRIOR_RESULT message)
        {
            return message.GetORDER_PRIOR(message.ORDER_PRIORRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OML_O35_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this OML_O35_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OML_O35_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OML_O35_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OML_O35_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this OML_O35_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get SPECIMEN_CONTAINER Records from OML_O35_SPECIMEN
        /// </summary>
        public static IEnumerable GetSPECIMEN_CONTAINERRecords(this OML_O35_SPECIMEN message)
        {
            object[] result = message.GetRecords("SPECIMEN_CONTAINERRepetitionsUsed", "GetSPECIMEN_CONTAINER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN_CONTAINER Records from OML_O35_SPECIMEN
        /// </summary>
        public static List<OML_O35_SPECIMEN_CONTAINER> GetAllSPECIMEN_CONTAINERRecords(this OML_O35_SPECIMEN message)
        {
            return message.GetAllRecords<OML_O35_SPECIMEN_CONTAINER>("SPECIMEN_CONTAINERRepetitionsUsed", "GetSPECIMEN_CONTAINER");
        }

        /// <summary>
        /// Add a new OML_O35_SPECIMEN to SPECIMEN_CONTAINER
        /// </summary>
        public static OML_O35_SPECIMEN_CONTAINER AddSPECIMEN_CONTAINER(this OML_O35_SPECIMEN message)
        {
            return message.GetSPECIMEN_CONTAINER(message.SPECIMEN_CONTAINERRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OML_O35_SPECIMEN_CONTAINER
        /// </summary>
        public static IEnumerable GetORDERRecords(this OML_O35_SPECIMEN_CONTAINER message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OML_O35_SPECIMEN_CONTAINER
        /// </summary>
        public static List<OML_O35_ORDER> GetAllORDERRecords(this OML_O35_SPECIMEN_CONTAINER message)
        {
            return message.GetAllRecords<OML_O35_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OML_O35_SPECIMEN_CONTAINER to ORDER
        /// </summary>
        public static OML_O35_ORDER AddORDER(this OML_O35_SPECIMEN_CONTAINER message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OML_O35_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OML_O35_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OML_O35_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OML_O35_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OML_O35_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OML_O35_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OML_O35_TIMING_PRIOR
        /// </summary>
        public static IEnumerable GetTQ2Records(this OML_O35_TIMING_PRIOR message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OML_O35_TIMING_PRIOR
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OML_O35_TIMING_PRIOR message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OML_O35_TIMING_PRIOR to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OML_O35_TIMING_PRIOR message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMN_O07_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O07_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O07_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O07_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMN_O07_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMN_O07_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMN_O07_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O07_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O07_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O07_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMN_O07_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OMN_O07_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMN_O07_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O07_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O07_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O07_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMN_O07_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMN_O07_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMN_O07_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMN_O07_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMN_O07_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMN_O07_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMN_O07_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMN_O07_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMN_O07_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMN_O07_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMN_O07_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMN_O07_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMN_O07_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMN_O07_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMP_O09_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMP_O09_COMPONENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMP_O09_COMPONENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMP_O09_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMP_O09_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMP_O09_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMP_O09_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMP_O09_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OMP_O09_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from OMP_O09_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this OMP_O09_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from OMP_O09_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this OMP_O09_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new OMP_O09_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this OMP_O09_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from OMP_O09_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OMP_O09_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OMP_O09_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OMP_O09_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new OMP_O09_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this OMP_O09_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMP_O09_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMP_O09_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMP_O09_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMP_O09_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMP_O09_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMP_O09_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMP_O09_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMP_O09_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMP_O09_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMP_O09_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMP_O09_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMP_O09_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMP_O09_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMP_O09_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMP_O09_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMS_O05_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O05_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O05_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O05_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMS_O05_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMS_O05_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMS_O05_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O05_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O05_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O05_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMS_O05_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OMS_O05_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMS_O05_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O05_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O05_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O05_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMS_O05_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMS_O05_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMS_O05_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMS_O05_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMS_O05_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMS_O05_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMS_O05_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMS_O05_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OMS_O05_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OMS_O05_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OMS_O05_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OMS_O05_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OMS_O05_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OMS_O05_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORB_O28_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORB_O28_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORB_O28_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORB_O28_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORB_O28_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORB_O28_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get ODS Records from ORD_O04_ORDER_DIET
        /// </summary>
        public static IEnumerable GetODSRecords(this ORD_O04_ORDER_DIET message)
        {
            object[] result = message.GetRecords("ODSRepetitionsUsed", "GetODS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODS Records from ORD_O04_ORDER_DIET
        /// </summary>
        public static List<ODS> GetAllODSRecords(this ORD_O04_ORDER_DIET message)
        {
            return message.GetAllRecords<ODS>("ODSRepetitionsUsed", "GetODS");
        }

        /// <summary>
        /// Add a new ORD_O04_ORDER_DIET to ODS
        /// </summary>
        public static ODS AddODS(this ORD_O04_ORDER_DIET message)
        {
            return message.GetODS(message.ODSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORD_O04_ORDER_DIET
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O04_ORDER_DIET message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O04_ORDER_DIET
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O04_ORDER_DIET message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORD_O04_ORDER_DIET to NTE
        /// </summary>
        public static NTE AddNTE(this ORD_O04_ORDER_DIET message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ODT Records from ORD_O04_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetODTRecords(this ORD_O04_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("ODTRepetitionsUsed", "GetODT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODT Records from ORD_O04_ORDER_TRAY
        /// </summary>
        public static List<ODT> GetAllODTRecords(this ORD_O04_ORDER_TRAY message)
        {
            return message.GetAllRecords<ODT>("ODTRepetitionsUsed", "GetODT");
        }

        /// <summary>
        /// Add a new ORD_O04_ORDER_TRAY to ODT
        /// </summary>
        public static ODT AddODT(this ORD_O04_ORDER_TRAY message)
        {
            return message.GetODT(message.ODTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORD_O04_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O04_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O04_ORDER_TRAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O04_ORDER_TRAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORD_O04_ORDER_TRAY to NTE
        /// </summary>
        public static NTE AddNTE(this ORD_O04_ORDER_TRAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORD_O04_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O04_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O04_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O04_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORD_O04_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORD_O04_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_DIET Records from ORD_O04_RESPONSE
        /// </summary>
        public static IEnumerable GetORDER_DIETRecords(this ORD_O04_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_DIET Records from ORD_O04_RESPONSE
        /// </summary>
        public static List<ORD_O04_ORDER_DIET> GetAllORDER_DIETRecords(this ORD_O04_RESPONSE message)
        {
            return message.GetAllRecords<ORD_O04_ORDER_DIET>("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");
        }

        /// <summary>
        /// Add a new ORD_O04_RESPONSE to ORDER_DIET
        /// </summary>
        public static ORD_O04_ORDER_DIET AddORDER_DIET(this ORD_O04_RESPONSE message)
        {
            return message.GetORDER_DIET(message.ORDER_DIETRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORD_O04_TIMING_DIET
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORD_O04_TIMING_DIET message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORD_O04_TIMING_DIET
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORD_O04_TIMING_DIET message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORD_O04_TIMING_DIET to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORD_O04_TIMING_DIET message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORD_O04_TIMING_TRAY
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORD_O04_TIMING_TRAY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORD_O04_TIMING_TRAY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORD_O04_TIMING_TRAY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORD_O04_TIMING_TRAY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORD_O04_TIMING_TRAY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_OBXNTE
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_OBXNTE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_OBXNTE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_OBXNTE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORF_R04_OBXNTE to NTE
        /// </summary>
        public static NTE AddNTE(this ORF_R04_OBXNTE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI to NTE
        /// </summary>
        public static NTE AddNTE(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBXNTE Records from ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static IEnumerable GetOBXNTERecords(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            object[] result = message.GetRecords("OBXNTERepetitionsUsed", "GetOBXNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBXNTE Records from ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static List<ORF_R04_OBXNTE> GetAllOBXNTERecords(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            return message.GetAllRecords<ORF_R04_OBXNTE>("OBXNTERepetitionsUsed", "GetOBXNTE");
        }

        /// <summary>
        /// Add a new ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI to OBXNTE
        /// </summary>
        public static ORF_R04_OBXNTE AddOBXNTE(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            return message.GetOBXNTE(message.OBXNTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI to CTI
        /// </summary>
        public static CTI AddCTI(this ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_PIDNTE
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_PIDNTE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_PIDNTE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_PIDNTE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORF_R04_PIDNTE to NTE
        /// </summary>
        public static NTE AddNTE(this ORF_R04_PIDNTE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORCOBRNTETQ1TQ2CTDOBXNTECTI Records from ORF_R04_PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static IEnumerable GetORCOBRNTETQ1TQ2CTDOBXNTECTIRecords(this ORF_R04_PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            object[] result = message.GetRecords("ORCOBRNTETQ1TQ2CTDOBXNTECTIRepetitionsUsed", "GetORCOBRNTETQ1TQ2CTDOBXNTECTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORCOBRNTETQ1TQ2CTDOBXNTECTI Records from ORF_R04_PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static List<ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI> GetAllORCOBRNTETQ1TQ2CTDOBXNTECTIRecords(this ORF_R04_PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            return message.GetAllRecords<ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI>("ORCOBRNTETQ1TQ2CTDOBXNTECTIRepetitionsUsed", "GetORCOBRNTETQ1TQ2CTDOBXNTECTI");
        }

        /// <summary>
        /// Add a new ORF_R04_PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI to ORCOBRNTETQ1TQ2CTDOBXNTECTI
        /// </summary>
        public static ORF_R04_ORCOBRNTETQ1TQ2CTDOBXNTECTI AddORCOBRNTETQ1TQ2CTDOBXNTECTI(this ORF_R04_PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI message)
        {
            return message.GetORCOBRNTETQ1TQ2CTDOBXNTECTI(message.ORCOBRNTETQ1TQ2CTDOBXNTECTIRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORF_R04_TQ1TQ2
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORF_R04_TQ1TQ2 message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORF_R04_TQ1TQ2
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORF_R04_TQ1TQ2 message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORF_R04_TQ1TQ2 to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORF_R04_TQ1TQ2 message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORG_O20_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORG_O20_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORG_O20_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORG_O20_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORG_O20_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORG_O20_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORG_O20_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORG_O20_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORG_O20_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORG_O20_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORG_O20_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this ORG_O20_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORG_O20_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORG_O20_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORG_O20_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORG_O20_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORG_O20_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORG_O20_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORG_O20_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORG_O20_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORG_O20_RESPONSE
        /// </summary>
        public static List<ORG_O20_ORDER> GetAllORDERRecords(this ORG_O20_RESPONSE message)
        {
            return message.GetAllRecords<ORG_O20_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORG_O20_RESPONSE to ORDER
        /// </summary>
        public static ORG_O20_ORDER AddORDER(this ORG_O20_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get SAC Records from ORG_O20_SPECIMEN
        /// </summary>
        public static IEnumerable GetSACRecords(this ORG_O20_SPECIMEN message)
        {
            object[] result = message.GetRecords("SACRepetitionsUsed", "GetSAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SAC Records from ORG_O20_SPECIMEN
        /// </summary>
        public static List<SAC> GetAllSACRecords(this ORG_O20_SPECIMEN message)
        {
            return message.GetAllRecords<SAC>("SACRepetitionsUsed", "GetSAC");
        }

        /// <summary>
        /// Add a new ORG_O20_SPECIMEN to SAC
        /// </summary>
        public static SAC AddSAC(this ORG_O20_SPECIMEN message)
        {
            return message.GetSAC(message.SACRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORG_O20_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORG_O20_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORG_O20_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORG_O20_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORG_O20_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORG_O20_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORI_O24_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORI_O24_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORI_O24_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORI_O24_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORI_O24_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORI_O24_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get IPC Records from ORI_O24_ORDER
        /// </summary>
        public static IEnumerable GetIPCRecords(this ORI_O24_ORDER message)
        {
            object[] result = message.GetRecords("IPCRepetitionsUsed", "GetIPC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IPC Records from ORI_O24_ORDER
        /// </summary>
        public static List<IPC> GetAllIPCRecords(this ORI_O24_ORDER message)
        {
            return message.GetAllRecords<IPC>("IPCRepetitionsUsed", "GetIPC");
        }

        /// <summary>
        /// Add a new ORI_O24_ORDER to IPC
        /// </summary>
        public static IPC AddIPC(this ORI_O24_ORDER message)
        {
            return message.GetIPC(message.IPCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORI_O24_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORI_O24_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORI_O24_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORI_O24_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORI_O24_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORI_O24_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORI_O24_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORI_O24_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORI_O24_RESPONSE
        /// </summary>
        public static List<ORI_O24_ORDER> GetAllORDERRecords(this ORI_O24_RESPONSE message)
        {
            return message.GetAllRecords<ORI_O24_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORI_O24_RESPONSE to ORDER
        /// </summary>
        public static ORI_O24_ORDER AddORDER(this ORI_O24_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORI_O24_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORI_O24_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORI_O24_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORI_O24_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORI_O24_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORI_O24_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get SAC Records from ORL_O22_SPECIMEN
        /// </summary>
        public static IEnumerable GetSACRecords(this ORL_O22_SPECIMEN message)
        {
            object[] result = message.GetRecords("SACRepetitionsUsed", "GetSAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SAC Records from ORL_O22_SPECIMEN
        /// </summary>
        public static List<SAC> GetAllSACRecords(this ORL_O22_SPECIMEN message)
        {
            return message.GetAllRecords<SAC>("SACRepetitionsUsed", "GetSAC");
        }

        /// <summary>
        /// Add a new ORL_O22_SPECIMEN to SAC
        /// </summary>
        public static SAC AddSAC(this ORL_O22_SPECIMEN message)
        {
            return message.GetSAC(message.SACRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORL_O22_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORL_O22_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORL_O22_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORL_O22_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORL_O22_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORL_O22_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get SPECIMEN Records from ORL_O34_PATIENT
        /// </summary>
        public static IEnumerable GetSPECIMENRecords(this ORL_O34_PATIENT message)
        {
            object[] result = message.GetRecords("SPECIMENRepetitionsUsed", "GetSPECIMEN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN Records from ORL_O34_PATIENT
        /// </summary>
        public static List<ORL_O34_SPECIMEN> GetAllSPECIMENRecords(this ORL_O34_PATIENT message)
        {
            return message.GetAllRecords<ORL_O34_SPECIMEN>("SPECIMENRepetitionsUsed", "GetSPECIMEN");
        }

        /// <summary>
        /// Add a new ORL_O34_PATIENT to SPECIMEN
        /// </summary>
        public static ORL_O34_SPECIMEN AddSPECIMEN(this ORL_O34_PATIENT message)
        {
            return message.GetSPECIMEN(message.SPECIMENRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ORL_O34_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this ORL_O34_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ORL_O34_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ORL_O34_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ORL_O34_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this ORL_O34_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get SAC Records from ORL_O34_SPECIMEN
        /// </summary>
        public static IEnumerable GetSACRecords(this ORL_O34_SPECIMEN message)
        {
            object[] result = message.GetRecords("SACRepetitionsUsed", "GetSAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SAC Records from ORL_O34_SPECIMEN
        /// </summary>
        public static List<SAC> GetAllSACRecords(this ORL_O34_SPECIMEN message)
        {
            return message.GetAllRecords<SAC>("SACRepetitionsUsed", "GetSAC");
        }

        /// <summary>
        /// Add a new ORL_O34_SPECIMEN to SAC
        /// </summary>
        public static SAC AddSAC(this ORL_O34_SPECIMEN message)
        {
            return message.GetSAC(message.SACRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORL_O34_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORL_O34_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORL_O34_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORL_O34_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORL_O34_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORL_O34_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get SPECIMEN Records from ORL_O36_PATIENT
        /// </summary>
        public static IEnumerable GetSPECIMENRecords(this ORL_O36_PATIENT message)
        {
            object[] result = message.GetRecords("SPECIMENRepetitionsUsed", "GetSPECIMEN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN Records from ORL_O36_PATIENT
        /// </summary>
        public static List<ORL_O36_SPECIMEN> GetAllSPECIMENRecords(this ORL_O36_PATIENT message)
        {
            return message.GetAllRecords<ORL_O36_SPECIMEN>("SPECIMENRepetitionsUsed", "GetSPECIMEN");
        }

        /// <summary>
        /// Add a new ORL_O36_PATIENT to SPECIMEN
        /// </summary>
        public static ORL_O36_SPECIMEN AddSPECIMEN(this ORL_O36_PATIENT message)
        {
            return message.GetSPECIMEN(message.SPECIMENRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ORL_O36_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this ORL_O36_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ORL_O36_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ORL_O36_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ORL_O36_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this ORL_O36_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get SPECIMEN_CONTAINER Records from ORL_O36_SPECIMEN
        /// </summary>
        public static IEnumerable GetSPECIMEN_CONTAINERRecords(this ORL_O36_SPECIMEN message)
        {
            object[] result = message.GetRecords("SPECIMEN_CONTAINERRepetitionsUsed", "GetSPECIMEN_CONTAINER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN_CONTAINER Records from ORL_O36_SPECIMEN
        /// </summary>
        public static List<ORL_O36_SPECIMEN_CONTAINER> GetAllSPECIMEN_CONTAINERRecords(this ORL_O36_SPECIMEN message)
        {
            return message.GetAllRecords<ORL_O36_SPECIMEN_CONTAINER>("SPECIMEN_CONTAINERRepetitionsUsed", "GetSPECIMEN_CONTAINER");
        }

        /// <summary>
        /// Add a new ORL_O36_SPECIMEN to SPECIMEN_CONTAINER
        /// </summary>
        public static ORL_O36_SPECIMEN_CONTAINER AddSPECIMEN_CONTAINER(this ORL_O36_SPECIMEN message)
        {
            return message.GetSPECIMEN_CONTAINER(message.SPECIMEN_CONTAINERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORL_O36_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORL_O36_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORL_O36_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORL_O36_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORL_O36_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORL_O36_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORM_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from ORM_O01_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this ORM_O01_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from ORM_O01_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this ORM_O01_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new ORM_O01_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this ORM_O01_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORM_O01_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORM_O01_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORM_O01_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORM_O01_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORM_O01_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this ORM_O01_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORM_O01_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetDG1Records(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ORM_O01_ORDER_DETAIL to DG1
        /// </summary>
        public static DG1 AddDG1(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORM_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ORM_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ORM_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this ORM_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORN_O08_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORN_O08_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORN_O08_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORN_O08_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORN_O08_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORN_O08_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORN_O08_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORN_O08_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORN_O08_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORN_O08_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORN_O08_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORN_O08_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORN_O08_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORN_O08_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORN_O08_RESPONSE
        /// </summary>
        public static List<ORN_O08_ORDER> GetAllORDERRecords(this ORN_O08_RESPONSE message)
        {
            return message.GetAllRecords<ORN_O08_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORN_O08_RESPONSE to ORDER
        /// </summary>
        public static ORN_O08_ORDER AddORDER(this ORN_O08_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORN_O08_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORN_O08_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORN_O08_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORN_O08_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORN_O08_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORN_O08_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORP_O10_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORP_O10_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORP_O10_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORP_O10_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORP_O10_COMPONENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORP_O10_COMPONENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this ORP_O10_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORP_O10_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORP_O10_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this ORP_O10_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this ORP_O10_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this ORP_O10_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new ORP_O10_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this ORP_O10_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORP_O10_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORP_O10_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORP_O10_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORP_O10_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORP_O10_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORP_O10_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORP_O10_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORP_O10_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORP_O10_RESPONSE
        /// </summary>
        public static List<ORP_O10_ORDER> GetAllORDERRecords(this ORP_O10_RESPONSE message)
        {
            return message.GetAllRecords<ORP_O10_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORP_O10_RESPONSE to ORDER
        /// </summary>
        public static ORP_O10_ORDER AddORDER(this ORP_O10_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORP_O10_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORP_O10_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORP_O10_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORP_O10_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORP_O10_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORP_O10_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORR_O02_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORR_O02_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORR_O02_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORR_O02_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORR_O02_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORR_O02_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORR_O02_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORR_O02_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this ORR_O02_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORR_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORR_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORR_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORR_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORR_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORR_O02_RESPONSE
        /// </summary>
        public static List<ORR_O02_ORDER> GetAllORDERRecords(this ORR_O02_RESPONSE message)
        {
            return message.GetAllRecords<ORR_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORR_O02_RESPONSE to ORDER
        /// </summary>
        public static ORR_O02_ORDER AddORDER(this ORR_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORS_O06_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORS_O06_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORS_O06_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORS_O06_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORS_O06_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORS_O06_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORS_O06_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORS_O06_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORS_O06_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORS_O06_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORS_O06_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORS_O06_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORS_O06_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORS_O06_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORS_O06_RESPONSE
        /// </summary>
        public static List<ORS_O06_ORDER> GetAllORDERRecords(this ORS_O06_RESPONSE message)
        {
            return message.GetAllRecords<ORS_O06_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORS_O06_RESPONSE to ORDER
        /// </summary>
        public static ORS_O06_ORDER AddORDER(this ORS_O06_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORS_O06_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORS_O06_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORS_O06_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORS_O06_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORS_O06_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORS_O06_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORU_R01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_QTY Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetTIMING_QTYRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("TIMING_QTYRepetitionsUsed", "GetTIMING_QTY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_QTY Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<ORU_R01_TIMING_QTY> GetAllTIMING_QTYRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<ORU_R01_TIMING_QTY>("TIMING_QTYRepetitionsUsed", "GetTIMING_QTY");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to TIMING_QTY
        /// </summary>
        public static ORU_R01_TIMING_QTY AddTIMING_QTY(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetTIMING_QTY(message.TIMING_QTYRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<ORU_R01_OBSERVATION> GetAllOBSERVATIONRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<ORU_R01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to OBSERVATION
        /// </summary>
        public static ORU_R01_OBSERVATION AddOBSERVATION(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetFT1Records(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<FT1> GetAllFT1Records(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to FT1
        /// </summary>
        public static FT1 AddFT1(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to CTI
        /// </summary>
        public static CTI AddCTI(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get SPECIMEN Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetSPECIMENRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("SPECIMENRepetitionsUsed", "GetSPECIMEN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<ORU_R01_SPECIMEN> GetAllSPECIMENRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<ORU_R01_SPECIMEN>("SPECIMENRepetitionsUsed", "GetSPECIMEN");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to SPECIMEN
        /// </summary>
        public static ORU_R01_SPECIMEN AddSPECIMEN(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetSPECIMEN(message.SPECIMENRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORU_R01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ORU_R01_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this ORU_R01_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ORU_R01_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ORU_R01_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ORU_R01_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this ORU_R01_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from ORU_R01_PATIENT_RESULT
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this ORU_R01_PATIENT_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from ORU_R01_PATIENT_RESULT
        /// </summary>
        public static List<ORU_R01_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this ORU_R01_PATIENT_RESULT message)
        {
            return message.GetAllRecords<ORU_R01_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new ORU_R01_PATIENT_RESULT to ORDER_OBSERVATION
        /// </summary>
        public static ORU_R01_ORDER_OBSERVATION AddORDER_OBSERVATION(this ORU_R01_PATIENT_RESULT message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ORU_R01_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this ORU_R01_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ORU_R01_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ORU_R01_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ORU_R01_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this ORU_R01_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORU_R01_TIMING_QTY
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORU_R01_TIMING_QTY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORU_R01_TIMING_QTY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORU_R01_TIMING_QTY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORU_R01_TIMING_QTY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORU_R01_TIMING_QTY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORU_R30_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R30_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R30_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R30_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORU_R30_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R30_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from ORU_R30_TIMING_QTY
        /// </summary>
        public static IEnumerable GetTQ2Records(this ORU_R30_TIMING_QTY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from ORU_R30_TIMING_QTY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this ORU_R30_TIMING_QTY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new ORU_R30_TIMING_QTY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this ORU_R30_TIMING_QTY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OSR_Q06_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OSR_Q06_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OSR_Q06_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OSR_Q06_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OSR_Q06_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OSR_Q06_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OSR_Q06_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OSR_Q06_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OSR_Q06_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OSR_Q06_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OSR_Q06_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this OSR_Q06_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OSR_Q06_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OSR_Q06_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OSR_Q06_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OSR_Q06_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OSR_Q06_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OSR_Q06_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OSR_Q06_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this OSR_Q06_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OSR_Q06_RESPONSE
        /// </summary>
        public static List<OSR_Q06_ORDER> GetAllORDERRecords(this OSR_Q06_RESPONSE message)
        {
            return message.GetAllRecords<OSR_Q06_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OSR_Q06_RESPONSE to ORDER
        /// </summary>
        public static OSR_Q06_ORDER AddORDER(this OSR_Q06_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OSR_Q06_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this OSR_Q06_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OSR_Q06_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OSR_Q06_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OSR_Q06_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OSR_Q06_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get SID Records from OUL_R21_OBSERVATION
        /// </summary>
        public static IEnumerable GetSIDRecords(this OUL_R21_OBSERVATION message)
        {
            object[] result = message.GetRecords("SIDRepetitionsUsed", "GetSID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SID Records from OUL_R21_OBSERVATION
        /// </summary>
        public static List<SID> GetAllSIDRecords(this OUL_R21_OBSERVATION message)
        {
            return message.GetAllRecords<SID>("SIDRepetitionsUsed", "GetSID");
        }

        /// <summary>
        /// Add a new OUL_R21_OBSERVATION to SID
        /// </summary>
        public static SID AddSID(this OUL_R21_OBSERVATION message)
        {
            return message.GetSID(message.SIDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R21_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R21_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R21_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R21_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R21_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R21_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R21_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static List<OUL_R21_OBSERVATION> GetAllOBSERVATIONRecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<OUL_R21_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new OUL_R21_ORDER_OBSERVATION to OBSERVATION
        /// </summary>
        public static OUL_R21_OBSERVATION AddOBSERVATION(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetCTIRecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OUL_R21_ORDER_OBSERVATION to CTI
        /// </summary>
        public static CTI AddCTI(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R21_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R21_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R21_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R21_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R21_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R21_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OUL_R21_TIMING_QTY
        /// </summary>
        public static IEnumerable GetTQ2Records(this OUL_R21_TIMING_QTY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OUL_R21_TIMING_QTY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OUL_R21_TIMING_QTY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OUL_R21_TIMING_QTY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OUL_R21_TIMING_QTY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get SID Records from OUL_R22_OBXTCDSIDNTE
        /// </summary>
        public static IEnumerable GetSIDRecords(this OUL_R22_OBXTCDSIDNTE message)
        {
            object[] result = message.GetRecords("SIDRepetitionsUsed", "GetSID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SID Records from OUL_R22_OBXTCDSIDNTE
        /// </summary>
        public static List<SID> GetAllSIDRecords(this OUL_R22_OBXTCDSIDNTE message)
        {
            return message.GetAllRecords<SID>("SIDRepetitionsUsed", "GetSID");
        }

        /// <summary>
        /// Add a new OUL_R22_OBXTCDSIDNTE to SID
        /// </summary>
        public static SID AddSID(this OUL_R22_OBXTCDSIDNTE message)
        {
            return message.GetSID(message.SIDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R22_OBXTCDSIDNTE
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R22_OBXTCDSIDNTE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R22_OBXTCDSIDNTE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R22_OBXTCDSIDNTE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R22_OBXTCDSIDNTE to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R22_OBXTCDSIDNTE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R22_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R22_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R22_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R22_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R22_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R22_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OUL_R22_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OUL_R22_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OUL_R22_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OUL_R22_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OUL_R22_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this OUL_R22_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R22_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R22_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R22_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R22_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R22_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R22_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OUL_R22_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this OUL_R22_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OUL_R22_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OUL_R22_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OUL_R22_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this OUL_R22_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OUL_R22_SPECIMEN
        /// </summary>
        public static IEnumerable GetORDERRecords(this OUL_R22_SPECIMEN message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OUL_R22_SPECIMEN
        /// </summary>
        public static List<OUL_R22_ORDER> GetAllORDERRecords(this OUL_R22_SPECIMEN message)
        {
            return message.GetAllRecords<OUL_R22_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OUL_R22_SPECIMEN to ORDER
        /// </summary>
        public static OUL_R22_ORDER AddORDER(this OUL_R22_SPECIMEN message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OUL_R22_TIMING_QTY
        /// </summary>
        public static IEnumerable GetTQ2Records(this OUL_R22_TIMING_QTY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OUL_R22_TIMING_QTY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OUL_R22_TIMING_QTY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OUL_R22_TIMING_QTY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OUL_R22_TIMING_QTY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OUL_R23_CONTAINER
        /// </summary>
        public static IEnumerable GetORDERRecords(this OUL_R23_CONTAINER message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OUL_R23_CONTAINER
        /// </summary>
        public static List<OUL_R23_ORDER> GetAllORDERRecords(this OUL_R23_CONTAINER message)
        {
            return message.GetAllRecords<OUL_R23_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OUL_R23_CONTAINER to ORDER
        /// </summary>
        public static OUL_R23_ORDER AddORDER(this OUL_R23_CONTAINER message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get SID Records from OUL_R23_OBXTCDSIDNTE
        /// </summary>
        public static IEnumerable GetSIDRecords(this OUL_R23_OBXTCDSIDNTE message)
        {
            object[] result = message.GetRecords("SIDRepetitionsUsed", "GetSID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SID Records from OUL_R23_OBXTCDSIDNTE
        /// </summary>
        public static List<SID> GetAllSIDRecords(this OUL_R23_OBXTCDSIDNTE message)
        {
            return message.GetAllRecords<SID>("SIDRepetitionsUsed", "GetSID");
        }

        /// <summary>
        /// Add a new OUL_R23_OBXTCDSIDNTE to SID
        /// </summary>
        public static SID AddSID(this OUL_R23_OBXTCDSIDNTE message)
        {
            return message.GetSID(message.SIDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R23_OBXTCDSIDNTE
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R23_OBXTCDSIDNTE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R23_OBXTCDSIDNTE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R23_OBXTCDSIDNTE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R23_OBXTCDSIDNTE to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R23_OBXTCDSIDNTE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R23_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R23_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R23_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R23_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R23_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R23_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OUL_R23_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OUL_R23_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OUL_R23_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OUL_R23_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OUL_R23_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this OUL_R23_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R23_PIDPD1NTE
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R23_PIDPD1NTE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R23_PIDPD1NTE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R23_PIDPD1NTE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R23_PIDPD1NTE to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R23_PIDPD1NTE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI
        /// </summary>
        public static IEnumerable GetOBXRecords(this OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI to OBX
        /// </summary>
        public static OBX AddOBX(this OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get CONTAINER Records from OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI
        /// </summary>
        public static IEnumerable GetCONTAINERRecords(this OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI message)
        {
            object[] result = message.GetRecords("CONTAINERRepetitionsUsed", "GetCONTAINER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CONTAINER Records from OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI
        /// </summary>
        public static List<OUL_R23_CONTAINER> GetAllCONTAINERRecords(this OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI message)
        {
            return message.GetAllRecords<OUL_R23_CONTAINER>("CONTAINERRepetitionsUsed", "GetCONTAINER");
        }

        /// <summary>
        /// Add a new OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI to CONTAINER
        /// </summary>
        public static OUL_R23_CONTAINER AddCONTAINER(this OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI message)
        {
            return message.GetCONTAINER(message.CONTAINERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OUL_R23_TQ1TQ2
        /// </summary>
        public static IEnumerable GetTQ2Records(this OUL_R23_TQ1TQ2 message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OUL_R23_TQ1TQ2
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OUL_R23_TQ1TQ2 message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OUL_R23_TQ1TQ2 to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OUL_R23_TQ1TQ2 message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get SID Records from OUL_R24_OBXTCDSIDNTE
        /// </summary>
        public static IEnumerable GetSIDRecords(this OUL_R24_OBXTCDSIDNTE message)
        {
            object[] result = message.GetRecords("SIDRepetitionsUsed", "GetSID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SID Records from OUL_R24_OBXTCDSIDNTE
        /// </summary>
        public static List<SID> GetAllSIDRecords(this OUL_R24_OBXTCDSIDNTE message)
        {
            return message.GetAllRecords<SID>("SIDRepetitionsUsed", "GetSID");
        }

        /// <summary>
        /// Add a new OUL_R24_OBXTCDSIDNTE to SID
        /// </summary>
        public static SID AddSID(this OUL_R24_OBXTCDSIDNTE message)
        {
            return message.GetSID(message.SIDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R24_OBXTCDSIDNTE
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R24_OBXTCDSIDNTE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R24_OBXTCDSIDNTE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R24_OBXTCDSIDNTE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R24_OBXTCDSIDNTE to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R24_OBXTCDSIDNTE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R24_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R24_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R24_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R24_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R24_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R24_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OUL_R24_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OUL_R24_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OUL_R24_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OUL_R24_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OUL_R24_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this OUL_R24_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OUL_R24_PIDPD1NTE
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R24_PIDPD1NTE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R24_PIDPD1NTE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R24_PIDPD1NTE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OUL_R24_PIDPD1NTE to NTE
        /// </summary>
        public static NTE AddNTE(this OUL_R24_PIDPD1NTE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from OUL_R24_SPMOBXSACINV
        /// </summary>
        public static IEnumerable GetOBXRecords(this OUL_R24_SPMOBXSACINV message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OUL_R24_SPMOBXSACINV
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OUL_R24_SPMOBXSACINV message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new OUL_R24_SPMOBXSACINV to OBX
        /// </summary>
        public static OBX AddOBX(this OUL_R24_SPMOBXSACINV message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from OUL_R24_TQ1TQ2
        /// </summary>
        public static IEnumerable GetTQ2Records(this OUL_R24_TQ1TQ2 message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from OUL_R24_TQ1TQ2
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this OUL_R24_TQ1TQ2 message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new OUL_R24_TQ1TQ2 to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this OUL_R24_TQ1TQ2 message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get PRB Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static IEnumerable GetPRBRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            object[] result = message.GetRecords("PRBRepetitionsUsed", "GetPRB");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRB Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static List<PRB> GetAllPRBRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetAllRecords<PRB>("PRBRepetitionsUsed", "GetPRB");
        }

        /// <summary>
        /// Add a new PEX_P07_ASSOCIATED_PERSON to PRB
        /// </summary>
        public static PRB AddPRB(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetPRB(message.PRBRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static IEnumerable GetOBXRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new PEX_P07_ASSOCIATED_PERSON to OBX
        /// </summary>
        public static OBX AddOBX(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1_TIMING_QTY Records from PEX_P07_ASSOCIATED_RX_ORDER
        /// </summary>
        public static IEnumerable GetNK1_TIMING_QTYRecords(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            object[] result = message.GetRecords("NK1_TIMING_QTYRepetitionsUsed", "GetNK1_TIMING_QTY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1_TIMING_QTY Records from PEX_P07_ASSOCIATED_RX_ORDER
        /// </summary>
        public static List<PEX_P07_NK1_TIMING_QTY> GetAllNK1_TIMING_QTYRecords(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            return message.GetAllRecords<PEX_P07_NK1_TIMING_QTY>("NK1_TIMING_QTYRepetitionsUsed", "GetNK1_TIMING_QTY");
        }

        /// <summary>
        /// Add a new PEX_P07_ASSOCIATED_RX_ORDER to NK1_TIMING_QTY
        /// </summary>
        public static PEX_P07_NK1_TIMING_QTY AddNK1_TIMING_QTY(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            return message.GetNK1_TIMING_QTY(message.NK1_TIMING_QTYRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from PEX_P07_ASSOCIATED_RX_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from PEX_P07_ASSOCIATED_RX_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new PEX_P07_ASSOCIATED_RX_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get PEX_OBSERVATION Records from PEX_P07_EXPERIENCE
        /// </summary>
        public static IEnumerable GetPEX_OBSERVATIONRecords(this PEX_P07_EXPERIENCE message)
        {
            object[] result = message.GetRecords("PEX_OBSERVATIONRepetitionsUsed", "GetPEX_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PEX_OBSERVATION Records from PEX_P07_EXPERIENCE
        /// </summary>
        public static List<PEX_P07_PEX_OBSERVATION> GetAllPEX_OBSERVATIONRecords(this PEX_P07_EXPERIENCE message)
        {
            return message.GetAllRecords<PEX_P07_PEX_OBSERVATION>("PEX_OBSERVATIONRepetitionsUsed", "GetPEX_OBSERVATION");
        }

        /// <summary>
        /// Add a new PEX_P07_EXPERIENCE to PEX_OBSERVATION
        /// </summary>
        public static PEX_P07_PEX_OBSERVATION AddPEX_OBSERVATION(this PEX_P07_EXPERIENCE message)
        {
            return message.GetPEX_OBSERVATION(message.PEX_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from PEX_P07_NK1_TIMING_QTY
        /// </summary>
        public static IEnumerable GetTQ2Records(this PEX_P07_NK1_TIMING_QTY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from PEX_P07_NK1_TIMING_QTY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this PEX_P07_NK1_TIMING_QTY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new PEX_P07_NK1_TIMING_QTY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this PEX_P07_NK1_TIMING_QTY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get PRB Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetPRBRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("PRBRepetitionsUsed", "GetPRB");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRB Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<PRB> GetAllPRBRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<PRB>("PRBRepetitionsUsed", "GetPRB");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_CAUSE to PRB
        /// </summary>
        public static PRB AddPRB(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetPRB(message.PRBRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetOBXRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_CAUSE to OBX
        /// </summary>
        public static OBX AddOBX(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetNTERecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_CAUSE to NTE
        /// </summary>
        public static NTE AddNTE(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PEX_CAUSE Records from PEX_P07_PEX_OBSERVATION
        /// </summary>
        public static IEnumerable GetPEX_CAUSERecords(this PEX_P07_PEX_OBSERVATION message)
        {
            object[] result = message.GetRecords("PEX_CAUSERepetitionsUsed", "GetPEX_CAUSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PEX_CAUSE Records from PEX_P07_PEX_OBSERVATION
        /// </summary>
        public static List<PEX_P07_PEX_CAUSE> GetAllPEX_CAUSERecords(this PEX_P07_PEX_OBSERVATION message)
        {
            return message.GetAllRecords<PEX_P07_PEX_CAUSE>("PEX_CAUSERepetitionsUsed", "GetPEX_CAUSE");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_OBSERVATION to PEX_CAUSE
        /// </summary>
        public static PEX_P07_PEX_CAUSE AddPEX_CAUSE(this PEX_P07_PEX_OBSERVATION message)
        {
            return message.GetPEX_CAUSE(message.PEX_CAUSERepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_QTY Records from PEX_P07_RX_ORDER
        /// </summary>
        public static IEnumerable GetTIMING_QTYRecords(this PEX_P07_RX_ORDER message)
        {
            object[] result = message.GetRecords("TIMING_QTYRepetitionsUsed", "GetTIMING_QTY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_QTY Records from PEX_P07_RX_ORDER
        /// </summary>
        public static List<PEX_P07_TIMING_QTY> GetAllTIMING_QTYRecords(this PEX_P07_RX_ORDER message)
        {
            return message.GetAllRecords<PEX_P07_TIMING_QTY>("TIMING_QTYRepetitionsUsed", "GetTIMING_QTY");
        }

        /// <summary>
        /// Add a new PEX_P07_RX_ORDER to TIMING_QTY
        /// </summary>
        public static PEX_P07_TIMING_QTY AddTIMING_QTY(this PEX_P07_RX_ORDER message)
        {
            return message.GetTIMING_QTY(message.TIMING_QTYRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from PEX_P07_RX_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this PEX_P07_RX_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from PEX_P07_RX_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this PEX_P07_RX_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new PEX_P07_RX_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this PEX_P07_RX_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get CSP Records from PEX_P07_STUDY
        /// </summary>
        public static IEnumerable GetCSPRecords(this PEX_P07_STUDY message)
        {
            object[] result = message.GetRecords("CSPRepetitionsUsed", "GetCSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CSP Records from PEX_P07_STUDY
        /// </summary>
        public static List<CSP> GetAllCSPRecords(this PEX_P07_STUDY message)
        {
            return message.GetAllRecords<CSP>("CSPRepetitionsUsed", "GetCSP");
        }

        /// <summary>
        /// Add a new PEX_P07_STUDY to CSP
        /// </summary>
        public static CSP AddCSP(this PEX_P07_STUDY message)
        {
            return message.GetCSP(message.CSPRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from PEX_P07_TIMING_QTY
        /// </summary>
        public static IEnumerable GetTQ2Records(this PEX_P07_TIMING_QTY message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from PEX_P07_TIMING_QTY
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this PEX_P07_TIMING_QTY message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new PEX_P07_TIMING_QTY to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this PEX_P07_TIMING_QTY message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from PMU_B07_CERTIFICATE
        /// </summary>
        public static IEnumerable GetROLRecords(this PMU_B07_CERTIFICATE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from PMU_B07_CERTIFICATE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this PMU_B07_CERTIFICATE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new PMU_B07_CERTIFICATE to ROL
        /// </summary>
        public static ROL AddROL(this PMU_B07_CERTIFICATE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_PATHWAY to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_PATHWAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_PATHWAY_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_PATHWAY_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_PATHWAY to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_PATHWAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_PATHWAY_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_PATHWAY_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATHWAY to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_PATHWAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATHWAY_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_PATHWAY_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PPT_PCL_PATIENT
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPT_PCL_PATIENT message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPT_PCL_PATIENT
        /// </summary>
        public static List<PPT_PCL_PATHWAY> GetAllPATHWAYRecords(this PPT_PCL_PATIENT message)
        {
            return message.GetAllRecords<PPT_PCL_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATIENT to PATHWAY
        /// </summary>
        public static PPT_PCL_PATHWAY AddPATHWAY(this PPT_PCL_PATIENT message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_GOAL_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PPV_PCA_PATIENT
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPV_PCA_PATIENT message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPV_PCA_PATIENT
        /// </summary>
        public static List<PPV_PCA_GOAL> GetAllGOALRecords(this PPV_PCA_PATIENT message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PPV_PCA_PATIENT to GOAL
        /// </summary>
        public static PPV_PCA_GOAL AddGOAL(this PPV_PCA_PATIENT message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PRR_PC5_PATIENT
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PRR_PC5_PATIENT message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PRR_PC5_PATIENT
        /// </summary>
        public static List<PRR_PC5_PROBLEM> GetAllPROBLEMRecords(this PRR_PC5_PATIENT message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PRR_PC5_PATIENT to PROBLEM
        /// </summary>
        public static PRR_PC5_PROBLEM AddPROBLEM(this PRR_PC5_PATIENT message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_PROBLEM_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATHWAY to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_PATHWAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATHWAY_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_PATHWAY_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PTR_PCF_PATIENT
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PTR_PCF_PATIENT message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PTR_PCF_PATIENT
        /// </summary>
        public static List<PTR_PCF_PATHWAY> GetAllPATHWAYRecords(this PTR_PCF_PATIENT message)
        {
            return message.GetAllRecords<PTR_PCF_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATIENT to PATHWAY
        /// </summary>
        public static PTR_PCF_PATHWAY AddPATHWAY(this PTR_PCF_PATIENT message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RAR_RAR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RAR_RAR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RAR_RAR_DEFINITION
        /// </summary>
        public static List<RAR_RAR_ORDER> GetAllORDERRecords(this RAR_RAR_DEFINITION message)
        {
            return message.GetAllRecords<RAR_RAR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RAR_RAR_DEFINITION to ORDER
        /// </summary>
        public static RAR_RAR_ORDER AddORDER(this RAR_RAR_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RAR_RAR_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAR_RAR_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAR_RAR_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAR_RAR_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RAR_RAR_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RAR_RAR_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RAR_RAR_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RAR_RAR_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RAR_RAR_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RAR_RAR_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RAR_RAR_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RAR_RAR_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get RXA Records from RAR_RAR_ORDER
        /// </summary>
        public static IEnumerable GetRXARecords(this RAR_RAR_ORDER message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RAR_RAR_ORDER
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RAR_RAR_ORDER message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Add a new RAR_RAR_ORDER to RXA
        /// </summary>
        public static RXA AddRXA(this RAR_RAR_ORDER message)
        {
            return message.GetRXA(message.RXARepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAR_RAR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAR_RAR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAR_RAR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAR_RAR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAR_RAR_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RAR_RAR_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXA Records from RAS_O17_ADMINISTRATION
        /// </summary>
        public static IEnumerable GetRXARecords(this RAS_O17_ADMINISTRATION message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RAS_O17_ADMINISTRATION
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RAS_O17_ADMINISTRATION message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Add a new RAS_O17_ADMINISTRATION to RXA
        /// </summary>
        public static RXA AddRXA(this RAS_O17_ADMINISTRATION message)
        {
            return message.GetRXA(message.RXARepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O17_COMPONENTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17_COMPONENTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17_COMPONENTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17_COMPONENTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O17_COMPONENTS to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O17_COMPONENTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_ENCODED Records from RAS_O17_ENCODING
        /// </summary>
        public static IEnumerable GetTIMING_ENCODEDRecords(this RAS_O17_ENCODING message)
        {
            object[] result = message.GetRecords("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_ENCODED Records from RAS_O17_ENCODING
        /// </summary>
        public static List<RAS_O17_TIMING_ENCODED> GetAllTIMING_ENCODEDRecords(this RAS_O17_ENCODING message)
        {
            return message.GetAllRecords<RAS_O17_TIMING_ENCODED>("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");
        }

        /// <summary>
        /// Add a new RAS_O17_ENCODING to TIMING_ENCODED
        /// </summary>
        public static RAS_O17_TIMING_ENCODED AddTIMING_ENCODED(this RAS_O17_ENCODING message)
        {
            return message.GetTIMING_ENCODED(message.TIMING_ENCODEDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RAS_O17_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAS_O17_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAS_O17_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAS_O17_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RAS_O17_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RAS_O17_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RAS_O17_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RAS_O17_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RAS_O17_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RAS_O17_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RAS_O17_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RAS_O17_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O17_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O17_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O17_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ADMINISTRATION Records from RAS_O17_ORDER
        /// </summary>
        public static IEnumerable GetADMINISTRATIONRecords(this RAS_O17_ORDER message)
        {
            object[] result = message.GetRecords("ADMINISTRATIONRepetitionsUsed", "GetADMINISTRATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ADMINISTRATION Records from RAS_O17_ORDER
        /// </summary>
        public static List<RAS_O17_ADMINISTRATION> GetAllADMINISTRATIONRecords(this RAS_O17_ORDER message)
        {
            return message.GetAllRecords<RAS_O17_ADMINISTRATION>("ADMINISTRATIONRepetitionsUsed", "GetADMINISTRATION");
        }

        /// <summary>
        /// Add a new RAS_O17_ORDER to ADMINISTRATION
        /// </summary>
        public static RAS_O17_ADMINISTRATION AddADMINISTRATION(this RAS_O17_ORDER message)
        {
            return message.GetADMINISTRATION(message.ADMINISTRATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from RAS_O17_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this RAS_O17_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from RAS_O17_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this RAS_O17_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new RAS_O17_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this RAS_O17_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O17_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O17_ORDER_DETAIL_SUPPLEMENT to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RAS_O17_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAS_O17_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RAS_O17_ORDER_DETAIL_SUPPLEMENT to RXR
        /// </summary>
        public static RXR AddRXR(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O17_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O17_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O17_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RAS_O17_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RAS_O17_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RAS_O17_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RAS_O17_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RAS_O17_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RAS_O17_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RAS_O17_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RAS_O17_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RAS_O17_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RAS_O17_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RAS_O17_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RAS_O17_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RAS_O17_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RAS_O17_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RAS_O17_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RAS_O17_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RAS_O17_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RAS_O17_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RCI_I05_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RCI_I05_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RCI_I05_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RCI_I05_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RCI_I05_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RCI_I05_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RCI_I05_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RCI_I05_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RCI_I05_OBSERVATION
        /// </summary>
        public static List<RCI_I05_RESULTS> GetAllRESULTSRecords(this RCI_I05_OBSERVATION message)
        {
            return message.GetAllRecords<RCI_I05_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RCI_I05_OBSERVATION to RESULTS
        /// </summary>
        public static RCI_I05_RESULTS AddRESULTS(this RCI_I05_OBSERVATION message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RCI_I05_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RCI_I05_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RCI_I05_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RCI_I05_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RCI_I05_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RCI_I05_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RCI_I05_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RCI_I05_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RCI_I05_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RCI_I05_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RCI_I05_RESULTS to NTE
        /// </summary>
        public static NTE AddNTE(this RCI_I05_RESULTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RCL_I06_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RCL_I06_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RCL_I06_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RCL_I06_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RCL_I06_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RCL_I06_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O11_COMPONENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O11_COMPONENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O11_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O11_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O11_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O11_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_ENCODED Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetTIMING_ENCODEDRecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_ENCODED Records from RDE_O11_ORDER
        /// </summary>
        public static List<RDE_O11_TIMING_ENCODED> GetAllTIMING_ENCODEDRecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<RDE_O11_TIMING_ENCODED>("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");
        }

        /// <summary>
        /// Add a new RDE_O11_ORDER to TIMING_ENCODED
        /// </summary>
        public static RDE_O11_TIMING_ENCODED AddTIMING_ENCODED(this RDE_O11_ORDER message)
        {
            return message.GetTIMING_ENCODED(message.TIMING_ENCODEDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDE_O11_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDE_O11_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RDE_O11_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDE_O11_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDE_O11_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RDE_O11_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from RDE_O11_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new RDE_O11_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this RDE_O11_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from RDE_O11_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new RDE_O11_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this RDE_O11_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O11_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O11_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDE_O11_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDE_O11_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDE_O11_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDE_O11_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDE_O11_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this RDE_O11_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O11_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O11_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RDE_O11_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RDE_O11_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RDE_O11_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RDE_O11_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RDE_O11_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RDE_O11_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RDE_O11_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RDE_O11_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RDE_O11_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RDE_O11_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RDE_O11_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RDE_O11_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RDE_O11_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RDE_O11_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RDE_O11_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RDE_O11_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RDE_O11_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RDE_O11_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O13_COMPONENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O13_COMPONENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_ENCODING
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_ENCODING message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_ENCODING
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_ENCODING message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O13_ENCODING to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O13_ENCODING message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_ENCODED Records from RDS_O13_ENCODING
        /// </summary>
        public static IEnumerable GetTIMING_ENCODEDRecords(this RDS_O13_ENCODING message)
        {
            object[] result = message.GetRecords("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_ENCODED Records from RDS_O13_ENCODING
        /// </summary>
        public static List<RDS_O13_TIMING_ENCODED> GetAllTIMING_ENCODEDRecords(this RDS_O13_ENCODING message)
        {
            return message.GetAllRecords<RDS_O13_TIMING_ENCODED>("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");
        }

        /// <summary>
        /// Add a new RDS_O13_ENCODING to TIMING_ENCODED
        /// </summary>
        public static RDS_O13_TIMING_ENCODED AddTIMING_ENCODED(this RDS_O13_ENCODING message)
        {
            return message.GetTIMING_ENCODED(message.TIMING_ENCODEDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDS_O13_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O13_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O13_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O13_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDS_O13_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RDS_O13_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDS_O13_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDS_O13_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDS_O13_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDS_O13_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDS_O13_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RDS_O13_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O13_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O13_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O13_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O13_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDS_O13_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O13_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O13_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O13_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDS_O13_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RDS_O13_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDS_O13_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDS_O13_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDS_O13_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDS_O13_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDS_O13_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RDS_O13_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from RDS_O13_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this RDS_O13_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from RDS_O13_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this RDS_O13_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new RDS_O13_ORDER to FT1
        /// </summary>
        public static FT1 AddFT1(this RDS_O13_ORDER message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O13_ORDER_DETAIL_SUPPLEMENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDS_O13_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O13_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDS_O13_ORDER_DETAIL_SUPPLEMENT to RXR
        /// </summary>
        public static RXR AddRXR(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O13_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O13_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RDS_O13_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RDS_O13_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RDS_O13_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RDS_O13_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RDS_O13_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RDS_O13_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RDS_O13_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RDS_O13_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RDS_O13_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RDS_O13_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RDS_O13_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RDS_O13_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RDS_O13_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RDS_O13_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RDS_O13_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RDS_O13_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RDS_O13_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RDS_O13_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from REF_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I12_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I12_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new REF_I12_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this REF_I12_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS_NOTES Records from REF_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTS_NOTESRecords(this REF_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS_NOTES Records from REF_I12_OBSERVATION
        /// </summary>
        public static List<REF_I12_RESULTS_NOTES> GetAllRESULTS_NOTESRecords(this REF_I12_OBSERVATION message)
        {
            return message.GetAllRecords<REF_I12_RESULTS_NOTES>("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");
        }

        /// <summary>
        /// Add a new REF_I12_OBSERVATION to RESULTS_NOTES
        /// </summary>
        public static REF_I12_RESULTS_NOTES AddRESULTS_NOTES(this REF_I12_OBSERVATION message)
        {
            return message.GetRESULTS_NOTES(message.RESULTS_NOTESRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from REF_I12_PROVIDER_CONTACT
        /// </summary>
        public static IEnumerable GetCTDRecords(this REF_I12_PROVIDER_CONTACT message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from REF_I12_PROVIDER_CONTACT
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this REF_I12_PROVIDER_CONTACT message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new REF_I12_PROVIDER_CONTACT to CTD
        /// </summary>
        public static CTD AddCTD(this REF_I12_PROVIDER_CONTACT message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from REF_I12_RESULTS_NOTES
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I12_RESULTS_NOTES message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I12_RESULTS_NOTES
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I12_RESULTS_NOTES message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new REF_I12_RESULTS_NOTES to NTE
        /// </summary>
        public static NTE AddNTE(this REF_I12_RESULTS_NOTES message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RER_RER_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RER_RER_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RER_RER_DEFINITION
        /// </summary>
        public static List<RER_RER_ORDER> GetAllORDERRecords(this RER_RER_DEFINITION message)
        {
            return message.GetAllRecords<RER_RER_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RER_RER_DEFINITION to ORDER
        /// </summary>
        public static RER_RER_ORDER AddORDER(this RER_RER_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RER_RER_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RER_RER_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RER_RER_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RER_RER_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RER_RER_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RER_RER_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RER_RER_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RER_RER_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RER_RER_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RER_RER_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RER_RER_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RER_RER_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RER_RER_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RER_RER_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RER_RER_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RER_RER_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RER_RER_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RER_RER_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RGR_RGR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RGR_RGR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RGR_RGR_DEFINITION
        /// </summary>
        public static List<RGR_RGR_ORDER> GetAllORDERRecords(this RGR_RGR_DEFINITION message)
        {
            return message.GetAllRecords<RGR_RGR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RGR_RGR_DEFINITION to ORDER
        /// </summary>
        public static RGR_RGR_ORDER AddORDER(this RGR_RGR_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGR_RGR_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGR_RGR_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGR_RGR_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGR_RGR_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGR_RGR_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RGR_RGR_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGR_RGR_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGR_RGR_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGR_RGR_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGR_RGR_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGR_RGR_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RGR_RGR_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get RXG Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXGRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXGRepetitionsUsed", "GetRXG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXG Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXG> GetAllRXGRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXG>("RXGRepetitionsUsed", "GetRXG");
        }

        /// <summary>
        /// Add a new RGR_RGR_ORDER to RXG
        /// </summary>
        public static RXG AddRXG(this RGR_RGR_ORDER message)
        {
            return message.GetRXG(message.RXGRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGR_RGR_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RGR_RGR_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGR_RGR_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RGR_RGR_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGR_RGR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGR_RGR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGR_RGR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGR_RGR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGR_RGR_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RGR_RGR_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGV_O15_COMPONENTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15_COMPONENTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15_COMPONENTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15_COMPONENTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGV_O15_COMPONENTS to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O15_COMPONENTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_ENCODED Records from RGV_O15_ENCODING
        /// </summary>
        public static IEnumerable GetTIMING_ENCODEDRecords(this RGV_O15_ENCODING message)
        {
            object[] result = message.GetRecords("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_ENCODED Records from RGV_O15_ENCODING
        /// </summary>
        public static List<RGV_O15_TIMING_ENCODED> GetAllTIMING_ENCODEDRecords(this RGV_O15_ENCODING message)
        {
            return message.GetAllRecords<RGV_O15_TIMING_ENCODED>("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");
        }

        /// <summary>
        /// Add a new RGV_O15_ENCODING to TIMING_ENCODED
        /// </summary>
        public static RGV_O15_TIMING_ENCODED AddTIMING_ENCODED(this RGV_O15_ENCODING message)
        {
            return message.GetTIMING_ENCODED(message.TIMING_ENCODEDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGV_O15_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O15_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O15_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O15_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGV_O15_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RGV_O15_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGV_O15_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGV_O15_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGV_O15_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGV_O15_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGV_O15_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RGV_O15_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_GIVE Records from RGV_O15_GIVE
        /// </summary>
        public static IEnumerable GetTIMING_GIVERecords(this RGV_O15_GIVE message)
        {
            object[] result = message.GetRecords("TIMING_GIVERepetitionsUsed", "GetTIMING_GIVE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_GIVE Records from RGV_O15_GIVE
        /// </summary>
        public static List<RGV_O15_TIMING_GIVE> GetAllTIMING_GIVERecords(this RGV_O15_GIVE message)
        {
            return message.GetAllRecords<RGV_O15_TIMING_GIVE>("TIMING_GIVERepetitionsUsed", "GetTIMING_GIVE");
        }

        /// <summary>
        /// Add a new RGV_O15_GIVE to TIMING_GIVE
        /// </summary>
        public static RGV_O15_TIMING_GIVE AddTIMING_GIVE(this RGV_O15_GIVE message)
        {
            return message.GetTIMING_GIVE(message.TIMING_GIVERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGV_O15_GIVE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O15_GIVE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O15_GIVE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O15_GIVE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGV_O15_GIVE to RXR
        /// </summary>
        public static RXR AddRXR(this RGV_O15_GIVE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGV_O15_GIVE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGV_O15_GIVE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGV_O15_GIVE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGV_O15_GIVE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGV_O15_GIVE to RXC
        /// </summary>
        public static RXC AddRXC(this RGV_O15_GIVE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RGV_O15_GIVE
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RGV_O15_GIVE message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RGV_O15_GIVE
        /// </summary>
        public static List<RGV_O15_OBSERVATION> GetAllOBSERVATIONRecords(this RGV_O15_GIVE message)
        {
            return message.GetAllRecords<RGV_O15_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RGV_O15_GIVE to OBSERVATION
        /// </summary>
        public static RGV_O15_OBSERVATION AddOBSERVATION(this RGV_O15_GIVE message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGV_O15_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGV_O15_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O15_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get GIVE Records from RGV_O15_ORDER
        /// </summary>
        public static IEnumerable GetGIVERecords(this RGV_O15_ORDER message)
        {
            object[] result = message.GetRecords("GIVERepetitionsUsed", "GetGIVE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GIVE Records from RGV_O15_ORDER
        /// </summary>
        public static List<RGV_O15_GIVE> GetAllGIVERecords(this RGV_O15_ORDER message)
        {
            return message.GetAllRecords<RGV_O15_GIVE>("GIVERepetitionsUsed", "GetGIVE");
        }

        /// <summary>
        /// Add a new RGV_O15_ORDER to GIVE
        /// </summary>
        public static RGV_O15_GIVE AddGIVE(this RGV_O15_ORDER message)
        {
            return message.GetGIVE(message.GIVERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGV_O15_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGV_O15_ORDER_DETAIL_SUPPLEMENT to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGV_O15_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O15_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGV_O15_ORDER_DETAIL_SUPPLEMENT to RXR
        /// </summary>
        public static RXR AddRXR(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGV_O15_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGV_O15_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O15_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RGV_O15_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RGV_O15_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RGV_O15_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RGV_O15_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RGV_O15_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RGV_O15_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RGV_O15_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RGV_O15_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RGV_O15_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RGV_O15_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RGV_O15_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RGV_O15_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RGV_O15_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RGV_O15_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RGV_O15_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RGV_O15_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RGV_O15_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RGV_O15_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RGV_O15_TIMING_GIVE
        /// </summary>
        public static IEnumerable GetTQ2Records(this RGV_O15_TIMING_GIVE message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RGV_O15_TIMING_GIVE
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RGV_O15_TIMING_GIVE message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RGV_O15_TIMING_GIVE to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RGV_O15_TIMING_GIVE message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ROR_ROR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this ROR_ROR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ROR_ROR_DEFINITION
        /// </summary>
        public static List<ROR_ROR_ORDER> GetAllORDERRecords(this ROR_ROR_DEFINITION message)
        {
            return message.GetAllRecords<ROR_ROR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ROR_ROR_DEFINITION to ORDER
        /// </summary>
        public static ROR_ROR_ORDER AddORDER(this ROR_ROR_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from ROR_ROR_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this ROR_ROR_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from ROR_ROR_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this ROR_ROR_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new ROR_ROR_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this ROR_ROR_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from ROR_ROR_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this ROR_ROR_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from ROR_ROR_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this ROR_ROR_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new ROR_ROR_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this ROR_ROR_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ROR_ROR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ROR_ROR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ROR_ROR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ROR_ROR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ROR_ROR_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ROR_ROR_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RPA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RPA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPA_I08_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RPA_I08_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RPA_I08_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPA_I08_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPA_I08_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPA_I08_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPA_I08_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPA_I08_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPA_I08_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RPA_I08_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RPA_I08_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPA_I08_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPA_I08_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RPA_I08_RESULTS to NTE
        /// </summary>
        public static NTE AddNTE(this RPA_I08_RESULTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RPI_I01_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RPI_I01_INSURANCE> GetAllINSURANCERecords(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RPI_I01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RPI_I01_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RPI_I01_INSURANCE AddINSURANCE(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPI_I01_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPI_I01_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPI_I01_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPI_I01_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPI_I01_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPI_I01_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RPI_I04_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RPI_I04_INSURANCE> GetAllINSURANCERecords(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RPI_I04_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RPI_I04_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RPI_I04_INSURANCE AddINSURANCE(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPI_I04_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPI_I04_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPI_I04_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPI_I04_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPI_I04_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPI_I04_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPL_I02_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPL_I02_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPL_I02_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPL_I02_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPL_I02_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPL_I02_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPR_I03_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPR_I03_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPR_I03_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPR_I03_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPR_I03_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPR_I03_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RQA_I08_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RQA_I08_INSURANCE> GetAllINSURANCERecords(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RQA_I08_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RQA_I08_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RQA_I08_INSURANCE AddINSURANCE(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I08_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQA_I08_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RQA_I08_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQA_I08_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQA_I08_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQA_I08_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQA_I08_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQA_I08_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQA_I08_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQA_I08_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I08_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I08_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I08_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQA_I08_RESULTS to NTE
        /// </summary>
        public static NTE AddNTE(this RQA_I08_RESULTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQC_I05_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQC_I05_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQC_I05_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQC_I05_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQC_I05_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQC_I05_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RQI_I01_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RQI_I01_INSURANCE> GetAllINSURANCERecords(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RQI_I01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RQI_I01_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RQI_I01_INSURANCE AddINSURANCE(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQI_I01_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQI_I01_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQI_I01_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQI_I01_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQI_I01_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQI_I01_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQP_I04_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQP_I04_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQP_I04_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQP_I04_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQP_I04_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQP_I04_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXA Records from RRA_O18_ADMINISTRATION
        /// </summary>
        public static IEnumerable GetRXARecords(this RRA_O18_ADMINISTRATION message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RRA_O18_ADMINISTRATION
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RRA_O18_ADMINISTRATION message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Add a new RRA_O18_ADMINISTRATION to RXA
        /// </summary>
        public static RXA AddRXA(this RRA_O18_ADMINISTRATION message)
        {
            return message.GetRXA(message.RXARepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRA_O18_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRA_O18_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRA_O18_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRA_O18_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRA_O18_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRA_O18_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRA_O18_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRA_O18_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRA_O18_RESPONSE
        /// </summary>
        public static List<RRA_O18_ORDER> GetAllORDERRecords(this RRA_O18_RESPONSE message)
        {
            return message.GetAllRecords<RRA_O18_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRA_O18_RESPONSE to ORDER
        /// </summary>
        public static RRA_O18_ORDER AddORDER(this RRA_O18_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RRA_O18_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RRA_O18_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RRA_O18_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RRA_O18_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RRA_O18_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RRA_O18_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRD_O14_DISPENSE
        /// </summary>
        public static IEnumerable GetNTERecords(this RRD_O14_DISPENSE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRD_O14_DISPENSE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRD_O14_DISPENSE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRD_O14_DISPENSE to NTE
        /// </summary>
        public static NTE AddNTE(this RRD_O14_DISPENSE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RRD_O14_DISPENSE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRD_O14_DISPENSE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRD_O14_DISPENSE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRD_O14_DISPENSE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RRD_O14_DISPENSE to RXR
        /// </summary>
        public static RXR AddRXR(this RRD_O14_DISPENSE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RRD_O14_DISPENSE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRD_O14_DISPENSE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRD_O14_DISPENSE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRD_O14_DISPENSE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RRD_O14_DISPENSE to RXC
        /// </summary>
        public static RXC AddRXC(this RRD_O14_DISPENSE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRD_O14_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRD_O14_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRD_O14_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRD_O14_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRD_O14_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRD_O14_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRD_O14_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRD_O14_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRD_O14_RESPONSE
        /// </summary>
        public static List<RRD_O14_ORDER> GetAllORDERRecords(this RRD_O14_RESPONSE message)
        {
            return message.GetAllRecords<RRD_O14_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRD_O14_RESPONSE to ORDER
        /// </summary>
        public static RRD_O14_ORDER AddORDER(this RRD_O14_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RRD_O14_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RRD_O14_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RRD_O14_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RRD_O14_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RRD_O14_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RRD_O14_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_ENCODED Records from RRE_O12_ENCODING
        /// </summary>
        public static IEnumerable GetTIMING_ENCODEDRecords(this RRE_O12_ENCODING message)
        {
            object[] result = message.GetRecords("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_ENCODED Records from RRE_O12_ENCODING
        /// </summary>
        public static List<RRE_O12_TIMING_ENCODED> GetAllTIMING_ENCODEDRecords(this RRE_O12_ENCODING message)
        {
            return message.GetAllRecords<RRE_O12_TIMING_ENCODED>("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");
        }

        /// <summary>
        /// Add a new RRE_O12_ENCODING to TIMING_ENCODED
        /// </summary>
        public static RRE_O12_TIMING_ENCODED AddTIMING_ENCODED(this RRE_O12_ENCODING message)
        {
            return message.GetTIMING_ENCODED(message.TIMING_ENCODEDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RRE_O12_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRE_O12_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRE_O12_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRE_O12_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RRE_O12_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RRE_O12_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RRE_O12_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRE_O12_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRE_O12_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRE_O12_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RRE_O12_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RRE_O12_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRE_O12_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRE_O12_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRE_O12_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRE_O12_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRE_O12_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRE_O12_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRE_O12_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRE_O12_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRE_O12_RESPONSE
        /// </summary>
        public static List<RRE_O12_ORDER> GetAllORDERRecords(this RRE_O12_RESPONSE message)
        {
            return message.GetAllRecords<RRE_O12_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRE_O12_RESPONSE to ORDER
        /// </summary>
        public static RRE_O12_ORDER AddORDER(this RRE_O12_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RRE_O12_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RRE_O12_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RRE_O12_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RRE_O12_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RRE_O12_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RRE_O12_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RRE_O12_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RRE_O12_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RRE_O12_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RRE_O12_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RRE_O12_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RRE_O12_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_GIVE Records from RRG_O16_GIVE
        /// </summary>
        public static IEnumerable GetTIMING_GIVERecords(this RRG_O16_GIVE message)
        {
            object[] result = message.GetRecords("TIMING_GIVERepetitionsUsed", "GetTIMING_GIVE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_GIVE Records from RRG_O16_GIVE
        /// </summary>
        public static List<RRG_O16_TIMING_GIVE> GetAllTIMING_GIVERecords(this RRG_O16_GIVE message)
        {
            return message.GetAllRecords<RRG_O16_TIMING_GIVE>("TIMING_GIVERepetitionsUsed", "GetTIMING_GIVE");
        }

        /// <summary>
        /// Add a new RRG_O16_GIVE to TIMING_GIVE
        /// </summary>
        public static RRG_O16_TIMING_GIVE AddTIMING_GIVE(this RRG_O16_GIVE message)
        {
            return message.GetTIMING_GIVE(message.TIMING_GIVERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RRG_O16_GIVE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRG_O16_GIVE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRG_O16_GIVE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRG_O16_GIVE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RRG_O16_GIVE to RXR
        /// </summary>
        public static RXR AddRXR(this RRG_O16_GIVE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RRG_O16_GIVE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRG_O16_GIVE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRG_O16_GIVE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRG_O16_GIVE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RRG_O16_GIVE to RXC
        /// </summary>
        public static RXC AddRXC(this RRG_O16_GIVE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRG_O16_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRG_O16_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRG_O16_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRG_O16_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRG_O16_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRG_O16_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRG_O16_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRG_O16_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRG_O16_RESPONSE
        /// </summary>
        public static List<RRG_O16_ORDER> GetAllORDERRecords(this RRG_O16_RESPONSE message)
        {
            return message.GetAllRecords<RRG_O16_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRG_O16_RESPONSE to ORDER
        /// </summary>
        public static RRG_O16_ORDER AddORDER(this RRG_O16_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RRG_O16_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RRG_O16_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RRG_O16_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RRG_O16_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RRG_O16_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RRG_O16_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RRG_O16_TIMING_GIVE
        /// </summary>
        public static IEnumerable GetTQ2Records(this RRG_O16_TIMING_GIVE message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RRG_O16_TIMING_GIVE
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RRG_O16_TIMING_GIVE message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RRG_O16_TIMING_GIVE to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RRG_O16_TIMING_GIVE message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRI_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I12_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I12_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRI_I12_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RRI_I12_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS_NOTES Records from RRI_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTS_NOTESRecords(this RRI_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS_NOTES Records from RRI_I12_OBSERVATION
        /// </summary>
        public static List<RRI_I12_RESULTS_NOTES> GetAllRESULTS_NOTESRecords(this RRI_I12_OBSERVATION message)
        {
            return message.GetAllRecords<RRI_I12_RESULTS_NOTES>("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");
        }

        /// <summary>
        /// Add a new RRI_I12_OBSERVATION to RESULTS_NOTES
        /// </summary>
        public static RRI_I12_RESULTS_NOTES AddRESULTS_NOTES(this RRI_I12_OBSERVATION message)
        {
            return message.GetRESULTS_NOTES(message.RESULTS_NOTESRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RRI_I12_PROVIDER_CONTACT
        /// </summary>
        public static IEnumerable GetCTDRecords(this RRI_I12_PROVIDER_CONTACT message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RRI_I12_PROVIDER_CONTACT
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RRI_I12_PROVIDER_CONTACT message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RRI_I12_PROVIDER_CONTACT to CTD
        /// </summary>
        public static CTD AddCTD(this RRI_I12_PROVIDER_CONTACT message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRI_I12_RESULTS_NOTES
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I12_RESULTS_NOTES message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I12_RESULTS_NOTES
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I12_RESULTS_NOTES message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRI_I12_RESULTS_NOTES to NTE
        /// </summary>
        public static NTE AddNTE(this RRI_I12_RESULTS_NOTES message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RDT Records from RSP_K11_ROW_DEFINITION
        /// </summary>
        public static IEnumerable GetRDTRecords(this RSP_K11_ROW_DEFINITION message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from RSP_K11_ROW_DEFINITION
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this RSP_K11_ROW_DEFINITION message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Add a new RSP_K11_ROW_DEFINITION to RDT
        /// </summary>
        public static RDT AddRDT(this RSP_K11_ROW_DEFINITION message)
        {
            return message.GetRDT(message.RDTRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RSP_K21_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNK1Records(this RSP_K21_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RSP_K21_QUERY_RESPONSE
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RSP_K21_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RSP_K21_QUERY_RESPONSE to NK1
        /// </summary>
        public static NK1 AddNK1(this RSP_K21_QUERY_RESPONSE message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get PRA Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetPRARecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("PRARepetitionsUsed", "GetPRA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRA Records from RSP_K25_STAFF
        /// </summary>
        public static List<PRA> GetAllPRARecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<PRA>("PRARepetitionsUsed", "GetPRA");
        }

        /// <summary>
        /// Add a new RSP_K25_STAFF to PRA
        /// </summary>
        public static PRA AddPRA(this RSP_K25_STAFF message)
        {
            return message.GetPRA(message.PRARepetitionsUsed);
        }

        /// <summary>
        /// Get ORG Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetORGRecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("ORGRepetitionsUsed", "GetORG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORG Records from RSP_K25_STAFF
        /// </summary>
        public static List<ORG> GetAllORGRecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<ORG>("ORGRepetitionsUsed", "GetORG");
        }

        /// <summary>
        /// Add a new RSP_K25_STAFF to ORG
        /// </summary>
        public static ORG AddORG(this RSP_K25_STAFF message)
        {
            return message.GetORG(message.ORGRepetitionsUsed);
        }

        /// <summary>
        /// Get AFF Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetAFFRecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("AFFRepetitionsUsed", "GetAFF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AFF Records from RSP_K25_STAFF
        /// </summary>
        public static List<AFF> GetAllAFFRecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<AFF>("AFFRepetitionsUsed", "GetAFF");
        }

        /// <summary>
        /// Add a new RSP_K25_STAFF to AFF
        /// </summary>
        public static AFF AddAFF(this RSP_K25_STAFF message)
        {
            return message.GetAFF(message.AFFRepetitionsUsed);
        }

        /// <summary>
        /// Get LAN Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetLANRecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("LANRepetitionsUsed", "GetLAN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LAN Records from RSP_K25_STAFF
        /// </summary>
        public static List<LAN> GetAllLANRecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<LAN>("LANRepetitionsUsed", "GetLAN");
        }

        /// <summary>
        /// Add a new RSP_K25_STAFF to LAN
        /// </summary>
        public static LAN AddLAN(this RSP_K25_STAFF message)
        {
            return message.GetLAN(message.LANRepetitionsUsed);
        }

        /// <summary>
        /// Get EDU Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetEDURecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("EDURepetitionsUsed", "GetEDU");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EDU Records from RSP_K25_STAFF
        /// </summary>
        public static List<EDU> GetAllEDURecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<EDU>("EDURepetitionsUsed", "GetEDU");
        }

        /// <summary>
        /// Add a new RSP_K25_STAFF to EDU
        /// </summary>
        public static EDU AddEDU(this RSP_K25_STAFF message)
        {
            return message.GetEDU(message.EDURepetitionsUsed);
        }

        /// <summary>
        /// Get CER Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetCERRecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("CERRepetitionsUsed", "GetCER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CER Records from RSP_K25_STAFF
        /// </summary>
        public static List<CER> GetAllCERRecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<CER>("CERRepetitionsUsed", "GetCER");
        }

        /// <summary>
        /// Add a new RSP_K25_STAFF to CER
        /// </summary>
        public static CER AddCER(this RSP_K25_STAFF message)
        {
            return message.GetCER(message.CERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_K31_COMPONENTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_K31_COMPONENTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_K31_COMPONENTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_K31_COMPONENTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_K31_COMPONENTS to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_K31_COMPONENTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_ENCODED Records from RSP_K31_ENCODING
        /// </summary>
        public static IEnumerable GetTIMING_ENCODEDRecords(this RSP_K31_ENCODING message)
        {
            object[] result = message.GetRecords("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_ENCODED Records from RSP_K31_ENCODING
        /// </summary>
        public static List<RSP_K31_TIMING_ENCODED> GetAllTIMING_ENCODEDRecords(this RSP_K31_ENCODING message)
        {
            return message.GetAllRecords<RSP_K31_TIMING_ENCODED>("TIMING_ENCODEDRepetitionsUsed", "GetTIMING_ENCODED");
        }

        /// <summary>
        /// Add a new RSP_K31_ENCODING to TIMING_ENCODED
        /// </summary>
        public static RSP_K31_TIMING_ENCODED AddTIMING_ENCODED(this RSP_K31_ENCODING message)
        {
            return message.GetTIMING_ENCODED(message.TIMING_ENCODEDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_K31_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_K31_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_K31_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_K31_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_K31_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_K31_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_K31_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_K31_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_K31_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_K31_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_K31_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_K31_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_K31_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_K31_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_K31_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_K31_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_K31_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_K31_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_K31_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_K31_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_K31_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_K31_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_K31_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_K31_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_K31_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_K31_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_K31_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_K31_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_K31_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_K31_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_K31_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_K31_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_K31_ORDER
        /// </summary>
        public static List<RSP_K31_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_K31_ORDER message)
        {
            return message.GetAllRecords<RSP_K31_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RSP_K31_ORDER to OBSERVATION
        /// </summary>
        public static RSP_K31_OBSERVATION AddOBSERVATION(this RSP_K31_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_K31_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_K31_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_K31_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_K31_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_K31_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_K31_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_K31_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_K31_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_K31_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_K31_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_K31_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_K31_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_K31_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_K31_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_K31_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_K31_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_K31_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_K31_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RSP_K31_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RSP_K31_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RSP_K31_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RSP_K31_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RSP_K31_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RSP_K31_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RSP_K31_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RSP_K31_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RSP_K31_RESPONSE
        /// </summary>
        public static List<RSP_K31_ORDER> GetAllORDERRecords(this RSP_K31_RESPONSE message)
        {
            return message.GetAllRecords<RSP_K31_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RSP_K31_RESPONSE to ORDER
        /// </summary>
        public static RSP_K31_ORDER AddORDER(this RSP_K31_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_K31_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_K31_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_K31_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_K31_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_K31_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_K31_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_K31_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_K31_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_K31_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_K31_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_K31_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_K31_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get LCH Records from RSP_Q11_MF_LOC_DEPT
        /// </summary>
        public static IEnumerable GetLCHRecords(this RSP_Q11_MF_LOC_DEPT message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from RSP_Q11_MF_LOC_DEPT
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this RSP_Q11_MF_LOC_DEPT message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Add a new RSP_Q11_MF_LOC_DEPT to LCH
        /// </summary>
        public static LCH AddLCH(this RSP_Q11_MF_LOC_DEPT message)
        {
            return message.GetLCH(message.LCHRepetitionsUsed);
        }

        /// <summary>
        /// Get LCC Records from RSP_Q11_MF_LOC_DEPT
        /// </summary>
        public static IEnumerable GetLCCRecords(this RSP_Q11_MF_LOC_DEPT message)
        {
            object[] result = message.GetRecords("LCCRepetitionsUsed", "GetLCC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCC Records from RSP_Q11_MF_LOC_DEPT
        /// </summary>
        public static List<LCC> GetAllLCCRecords(this RSP_Q11_MF_LOC_DEPT message)
        {
            return message.GetAllRecords<LCC>("LCCRepetitionsUsed", "GetLCC");
        }

        /// <summary>
        /// Add a new RSP_Q11_MF_LOC_DEPT to LCC
        /// </summary>
        public static LCC AddLCC(this RSP_Q11_MF_LOC_DEPT message)
        {
            return message.GetLCC(message.LCCRepetitionsUsed);
        }

        /// <summary>
        /// Get LCH Records from RSP_Q11_QUERY_RESULT_CLUSTER
        /// </summary>
        public static IEnumerable GetLCHRecords(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from RSP_Q11_QUERY_RESULT_CLUSTER
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Add a new RSP_Q11_QUERY_RESULT_CLUSTER to LCH
        /// </summary>
        public static LCH AddLCH(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            return message.GetLCH(message.LCHRepetitionsUsed);
        }

        /// <summary>
        /// Get LRL Records from RSP_Q11_QUERY_RESULT_CLUSTER
        /// </summary>
        public static IEnumerable GetLRLRecords(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            object[] result = message.GetRecords("LRLRepetitionsUsed", "GetLRL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LRL Records from RSP_Q11_QUERY_RESULT_CLUSTER
        /// </summary>
        public static List<LRL> GetAllLRLRecords(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            return message.GetAllRecords<LRL>("LRLRepetitionsUsed", "GetLRL");
        }

        /// <summary>
        /// Add a new RSP_Q11_QUERY_RESULT_CLUSTER to LRL
        /// </summary>
        public static LRL AddLRL(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            return message.GetLRL(message.LRLRepetitionsUsed);
        }

        /// <summary>
        /// Get MF_LOC_DEPT Records from RSP_Q11_QUERY_RESULT_CLUSTER
        /// </summary>
        public static IEnumerable GetMF_LOC_DEPTRecords(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            object[] result = message.GetRecords("MF_LOC_DEPTRepetitionsUsed", "GetMF_LOC_DEPT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_LOC_DEPT Records from RSP_Q11_QUERY_RESULT_CLUSTER
        /// </summary>
        public static List<RSP_Q11_MF_LOC_DEPT> GetAllMF_LOC_DEPTRecords(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            return message.GetAllRecords<RSP_Q11_MF_LOC_DEPT>("MF_LOC_DEPTRepetitionsUsed", "GetMF_LOC_DEPT");
        }

        /// <summary>
        /// Add a new RSP_Q11_QUERY_RESULT_CLUSTER to MF_LOC_DEPT
        /// </summary>
        public static RSP_Q11_MF_LOC_DEPT AddMF_LOC_DEPT(this RSP_Q11_QUERY_RESULT_CLUSTER message)
        {
            return message.GetMF_LOC_DEPT(message.MF_LOC_DEPTRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z82_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z82_COMMON_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z82_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z82_COMMON_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_Z82_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static List<RSP_Z82_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetAllRecords<RSP_Z82_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RSP_Z82_COMMON_ORDER to OBSERVATION
        /// </summary>
        public static RSP_Z82_OBSERVATION AddOBSERVATION(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z82_ENCODED_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z82_ENCODED_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z82_ENCODED_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z82_ENCODED_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z82_ENCODED_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z82_ENCODED_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z82_ENCODED_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z82_ENCODED_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z82_ENCODED_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z82_ENCODED_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z82_ENCODED_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z82_ENCODED_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z82_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z82_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z82_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z82_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z82_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z82_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z82_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z82_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z82_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z82_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z82_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z82_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z82_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z82_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z82_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z82_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z82_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z82_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z82_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z82_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z82_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z82_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z82_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z82_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get COMMON_ORDER Records from RSP_Z82_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this RSP_Z82_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from RSP_Z82_QUERY_RESPONSE
        /// </summary>
        public static List<RSP_Z82_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this RSP_Z82_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<RSP_Z82_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Add a new RSP_Z82_QUERY_RESPONSE to COMMON_ORDER
        /// </summary>
        public static RSP_Z82_COMMON_ORDER AddCOMMON_ORDER(this RSP_Z82_QUERY_RESPONSE message)
        {
            return message.GetCOMMON_ORDER(message.COMMON_ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_Z82_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_Z82_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_Z82_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_Z82_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_Z82_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_Z82_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_Z82_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_Z82_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_Z82_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_Z82_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_Z82_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_Z82_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z82_TREATMENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z82_TREATMENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z82_TREATMENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z82_TREATMENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z82_TREATMENT to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z82_TREATMENT message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z82_TREATMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z82_TREATMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z82_TREATMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z82_TREATMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z82_TREATMENT to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z82_TREATMENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RSP_Z82_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this RSP_Z82_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RSP_Z82_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RSP_Z82_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RSP_Z82_VISIT to AL1
        /// </summary>
        public static AL1 AddAL1(this RSP_Z82_VISIT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_ADMINISTRATION
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_ADMINISTRATION message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_ADMINISTRATION
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_ADMINISTRATION message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z86_ADMINISTRATION to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z86_ADMINISTRATION message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_ADMINISTRATION
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_ADMINISTRATION message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_ADMINISTRATION
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_ADMINISTRATION message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z86_ADMINISTRATION to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z86_ADMINISTRATION message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_Z86_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_Z86_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_Z86_COMMON_ORDER
        /// </summary>
        public static List<RSP_Z86_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_Z86_COMMON_ORDER message)
        {
            return message.GetAllRecords<RSP_Z86_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RSP_Z86_COMMON_ORDER to OBSERVATION
        /// </summary>
        public static RSP_Z86_OBSERVATION AddOBSERVATION(this RSP_Z86_COMMON_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_DISPENSE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_DISPENSE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_DISPENSE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_DISPENSE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z86_DISPENSE to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z86_DISPENSE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_DISPENSE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_DISPENSE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_DISPENSE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_DISPENSE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z86_DISPENSE to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z86_DISPENSE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_ENCODED_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_ENCODED_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_ENCODED_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_ENCODED_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z86_ENCODED_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z86_ENCODED_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_ENCODED_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_ENCODED_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_ENCODED_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_ENCODED_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z86_ENCODED_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z86_ENCODED_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_GIVE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_GIVE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_GIVE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_GIVE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z86_GIVE to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z86_GIVE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_GIVE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_GIVE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_GIVE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_GIVE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z86_GIVE to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z86_GIVE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z86_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z86_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z86_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z86_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z86_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z86_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z86_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z86_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_ORDER_DETAIL
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z86_ORDER_DETAIL to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z86_ORDER_DETAIL message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z86_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z86_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z86_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z86_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z86_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z86_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RSP_Z86_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RSP_Z86_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RSP_Z86_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RSP_Z86_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RSP_Z86_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RSP_Z86_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get COMMON_ORDER Records from RSP_Z86_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this RSP_Z86_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from RSP_Z86_QUERY_RESPONSE
        /// </summary>
        public static List<RSP_Z86_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this RSP_Z86_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<RSP_Z86_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Add a new RSP_Z86_QUERY_RESPONSE to COMMON_ORDER
        /// </summary>
        public static RSP_Z86_COMMON_ORDER AddCOMMON_ORDER(this RSP_Z86_QUERY_RESPONSE message)
        {
            return message.GetCOMMON_ORDER(message.COMMON_ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_Z86_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_Z86_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_Z86_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_Z86_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_Z86_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_Z86_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_Z86_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_Z86_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_Z86_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_Z86_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_Z86_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_Z86_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RSP_Z88_ALLERGY
        /// </summary>
        public static IEnumerable GetAL1Records(this RSP_Z88_ALLERGY message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RSP_Z88_ALLERGY
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RSP_Z88_ALLERGY message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RSP_Z88_ALLERGY to AL1
        /// </summary>
        public static AL1 AddAL1(this RSP_Z88_ALLERGY message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z88_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z88_COMMON_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z88_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z88_COMMON_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_Z88_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static List<RSP_Z88_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetAllRecords<RSP_Z88_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RSP_Z88_COMMON_ORDER to OBSERVATION
        /// </summary>
        public static RSP_Z88_OBSERVATION AddOBSERVATION(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z88_COMPONENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z88_COMPONENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z88_COMPONENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z88_COMPONENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z88_COMPONENT to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z88_COMPONENT message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z88_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z88_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z88_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z88_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z88_COMPONENT to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z88_COMPONENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z88_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z88_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z88_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z88_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z88_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z88_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z88_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z88_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z88_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z88_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z88_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z88_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z88_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z88_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z88_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z88_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z88_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z88_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RSP_Z88_ORDER_ENCODED
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z88_ORDER_ENCODED message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z88_ORDER_ENCODED
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z88_ORDER_ENCODED message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RSP_Z88_ORDER_ENCODED to RXR
        /// </summary>
        public static RXR AddRXR(this RSP_Z88_ORDER_ENCODED message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RSP_Z88_ORDER_ENCODED
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z88_ORDER_ENCODED message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z88_ORDER_ENCODED
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z88_ORDER_ENCODED message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RSP_Z88_ORDER_ENCODED to RXC
        /// </summary>
        public static RXC AddRXC(this RSP_Z88_ORDER_ENCODED message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z88_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z88_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z88_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z88_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z88_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z88_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get COMMON_ORDER Records from RSP_Z88_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this RSP_Z88_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from RSP_Z88_QUERY_RESPONSE
        /// </summary>
        public static List<RSP_Z88_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this RSP_Z88_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<RSP_Z88_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Add a new RSP_Z88_QUERY_RESPONSE to COMMON_ORDER
        /// </summary>
        public static RSP_Z88_COMMON_ORDER AddCOMMON_ORDER(this RSP_Z88_QUERY_RESPONSE message)
        {
            return message.GetCOMMON_ORDER(message.COMMON_ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_Z88_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_Z88_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_Z88_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_Z88_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_Z88_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_Z88_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_Z88_TIMING_ENCODED
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_Z88_TIMING_ENCODED message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_Z88_TIMING_ENCODED
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_Z88_TIMING_ENCODED message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_Z88_TIMING_ENCODED to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_Z88_TIMING_ENCODED message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z90_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z90_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z90_COMMON_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z90_COMMON_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z90_COMMON_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z90_COMMON_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_Z90_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_Z90_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_Z90_COMMON_ORDER
        /// </summary>
        public static List<RSP_Z90_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_Z90_COMMON_ORDER message)
        {
            return message.GetAllRecords<RSP_Z90_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RSP_Z90_COMMON_ORDER to OBSERVATION
        /// </summary>
        public static RSP_Z90_OBSERVATION AddOBSERVATION(this RSP_Z90_COMMON_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z90_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z90_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z90_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z90_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z90_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z90_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RSP_Z90_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this RSP_Z90_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RSP_Z90_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RSP_Z90_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RSP_Z90_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this RSP_Z90_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RSP_Z90_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z90_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z90_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z90_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RSP_Z90_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RSP_Z90_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get COMMON_ORDER Records from RSP_Z90_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this RSP_Z90_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from RSP_Z90_QUERY_RESPONSE
        /// </summary>
        public static List<RSP_Z90_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this RSP_Z90_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<RSP_Z90_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Add a new RSP_Z90_QUERY_RESPONSE to COMMON_ORDER
        /// </summary>
        public static RSP_Z90_COMMON_ORDER AddCOMMON_ORDER(this RSP_Z90_QUERY_RESPONSE message)
        {
            return message.GetCOMMON_ORDER(message.COMMON_ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from RSP_Z90_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this RSP_Z90_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from RSP_Z90_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this RSP_Z90_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new RSP_Z90_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this RSP_Z90_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from RSP_Z90_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this RSP_Z90_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from RSP_Z90_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this RSP_Z90_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new RSP_Z90_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this RSP_Z90_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get RDT Records from RTB_K13_ROW_DEFINITION
        /// </summary>
        public static IEnumerable GetRDTRecords(this RTB_K13_ROW_DEFINITION message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from RTB_K13_ROW_DEFINITION
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this RTB_K13_ROW_DEFINITION message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Add a new RTB_K13_ROW_DEFINITION to RDT
        /// </summary>
        public static RDT AddRDT(this RTB_K13_ROW_DEFINITION message)
        {
            return message.GetRDT(message.RDTRepetitionsUsed);
        }

        /// <summary>
        /// Get RDT Records from RTB_Z74_ROW_DEFINITION
        /// </summary>
        public static IEnumerable GetRDTRecords(this RTB_Z74_ROW_DEFINITION message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from RTB_Z74_ROW_DEFINITION
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this RTB_Z74_ROW_DEFINITION message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Add a new RTB_Z74_ROW_DEFINITION to RDT
        /// </summary>
        public static RDT AddRDT(this RTB_Z74_ROW_DEFINITION message)
        {
            return message.GetRDT(message.RDTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S12_GENERAL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12_GENERAL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S12_LOCATION_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12_LOCATION_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from SIU_S12_PATIENT
        /// </summary>
        public static IEnumerable GetOBXRecords(this SIU_S12_PATIENT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from SIU_S12_PATIENT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this SIU_S12_PATIENT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new SIU_S12_PATIENT to OBX
        /// </summary>
        public static OBX AddOBX(this SIU_S12_PATIENT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from SIU_S12_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SIU_S12_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SIU_S12_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SIU_S12_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new SIU_S12_PATIENT to DG1
        /// </summary>
        public static DG1 AddDG1(this SIU_S12_PATIENT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S12_PERSONNEL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12_PERSONNEL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S12_SERVICE to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12_SERVICE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SQM_S25_REQUEST
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SQM_S25_REQUEST message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SQM_S25_REQUEST
        /// </summary>
        public static List<SQM_S25_RESOURCES> GetAllRESOURCESRecords(this SQM_S25_REQUEST message)
        {
            return message.GetAllRecords<SQM_S25_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SQM_S25_REQUEST to RESOURCES
        /// </summary>
        public static SQM_S25_RESOURCES AddRESOURCES(this SQM_S25_REQUEST message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_GENERAL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_GENERAL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_LOCATION_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_LOCATION_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_PERSONNEL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_PERSONNEL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ1 Records from SQR_S25_SCHEDULE
        /// </summary>
        public static IEnumerable GetTQ1Records(this SQR_S25_SCHEDULE message)
        {
            object[] result = message.GetRecords("TQ1RepetitionsUsed", "GetTQ1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ1 Records from SQR_S25_SCHEDULE
        /// </summary>
        public static List<TQ1> GetAllTQ1Records(this SQR_S25_SCHEDULE message)
        {
            return message.GetAllRecords<TQ1>("TQ1RepetitionsUsed", "GetTQ1");
        }

        /// <summary>
        /// Add a new SQR_S25_SCHEDULE to TQ1
        /// </summary>
        public static TQ1 AddTQ1(this SQR_S25_SCHEDULE message)
        {
            return message.GetTQ1(message.TQ1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_SCHEDULE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_SCHEDULE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_SCHEDULE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_SCHEDULE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_SCHEDULE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_SCHEDULE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SQR_S25_SCHEDULE
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SQR_S25_SCHEDULE message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SQR_S25_SCHEDULE
        /// </summary>
        public static List<SQR_S25_RESOURCES> GetAllRESOURCESRecords(this SQR_S25_SCHEDULE message)
        {
            return message.GetAllRecords<SQR_S25_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SQR_S25_SCHEDULE to RESOURCES
        /// </summary>
        public static SQR_S25_RESOURCES AddRESOURCES(this SQR_S25_SCHEDULE message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_SERVICE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_SERVICE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S01_GENERAL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01_GENERAL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S01_LOCATION_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01_LOCATION_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from SRM_S01_PATIENT
        /// </summary>
        public static IEnumerable GetOBXRecords(this SRM_S01_PATIENT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from SRM_S01_PATIENT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this SRM_S01_PATIENT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new SRM_S01_PATIENT to OBX
        /// </summary>
        public static OBX AddOBX(this SRM_S01_PATIENT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from SRM_S01_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SRM_S01_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SRM_S01_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SRM_S01_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new SRM_S01_PATIENT to DG1
        /// </summary>
        public static DG1 AddDG1(this SRM_S01_PATIENT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S01_PERSONNEL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S01_SERVICE to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01_SERVICE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_GENERAL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_GENERAL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_LOCATION_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_LOCATION_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from SRR_S01_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SRR_S01_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SRR_S01_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SRR_S01_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new SRR_S01_PATIENT to DG1
        /// </summary>
        public static DG1 AddDG1(this SRR_S01_PATIENT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_PERSONNEL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ1 Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetTQ1Records(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("TQ1RepetitionsUsed", "GetTQ1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ1 Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<TQ1> GetAllTQ1Records(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<TQ1>("TQ1RepetitionsUsed", "GetTQ1");
        }

        /// <summary>
        /// Add a new SRR_S01_SCHEDULE to TQ1
        /// </summary>
        public static TQ1 AddTQ1(this SRR_S01_SCHEDULE message)
        {
            return message.GetTQ1(message.TQ1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_SCHEDULE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_SCHEDULE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<SRR_S01_RESOURCES> GetAllRESOURCESRecords(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<SRR_S01_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRR_S01_SCHEDULE to RESOURCES
        /// </summary>
        public static SRR_S01_RESOURCES AddRESOURCES(this SRR_S01_SCHEDULE message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_SERVICE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_SERVICE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get SPM Records from SSR_U04_SPECIMEN_CONTAINER
        /// </summary>
        public static IEnumerable GetSPMRecords(this SSR_U04_SPECIMEN_CONTAINER message)
        {
            object[] result = message.GetRecords("SPMRepetitionsUsed", "GetSPM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPM Records from SSR_U04_SPECIMEN_CONTAINER
        /// </summary>
        public static List<SPM> GetAllSPMRecords(this SSR_U04_SPECIMEN_CONTAINER message)
        {
            return message.GetAllRecords<SPM>("SPMRepetitionsUsed", "GetSPM");
        }

        /// <summary>
        /// Add a new SSR_U04_SPECIMEN_CONTAINER to SPM
        /// </summary>
        public static SPM AddSPM(this SSR_U04_SPECIMEN_CONTAINER message)
        {
            return message.GetSPM(message.SPMRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from SSU_U03_SPECIMEN
        /// </summary>
        public static IEnumerable GetOBXRecords(this SSU_U03_SPECIMEN message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from SSU_U03_SPECIMEN
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this SSU_U03_SPECIMEN message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new SSU_U03_SPECIMEN to OBX
        /// </summary>
        public static OBX AddOBX(this SSU_U03_SPECIMEN message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from SSU_U03_SPECIMEN_CONTAINER
        /// </summary>
        public static IEnumerable GetOBXRecords(this SSU_U03_SPECIMEN_CONTAINER message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from SSU_U03_SPECIMEN_CONTAINER
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this SSU_U03_SPECIMEN_CONTAINER message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new SSU_U03_SPECIMEN_CONTAINER to OBX
        /// </summary>
        public static OBX AddOBX(this SSU_U03_SPECIMEN_CONTAINER message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get PSHPDC Records from SUR_P09_FACPSHPDCPSHFACPDCNTEED
        /// </summary>
        public static IEnumerable GetPSHPDCRecords(this SUR_P09_FACPSHPDCPSHFACPDCNTEED message)
        {
            object[] result = message.GetRecords("PSHPDCRepetitionsUsed", "GetPSHPDC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PSHPDC Records from SUR_P09_FACPSHPDCPSHFACPDCNTEED
        /// </summary>
        public static List<SUR_P09_PSHPDC> GetAllPSHPDCRecords(this SUR_P09_FACPSHPDCPSHFACPDCNTEED message)
        {
            return message.GetAllRecords<SUR_P09_PSHPDC>("PSHPDCRepetitionsUsed", "GetPSHPDC");
        }

        /// <summary>
        /// Add a new SUR_P09_FACPSHPDCPSHFACPDCNTEED to PSHPDC
        /// </summary>
        public static SUR_P09_PSHPDC AddPSHPDC(this SUR_P09_FACPSHPDCPSHFACPDCNTEED message)
        {
            return message.GetPSHPDC(message.PSHPDCRepetitionsUsed);
        }

        /// <summary>
        /// Get FACPDCNTE Records from SUR_P09_FACPSHPDCPSHFACPDCNTEED
        /// </summary>
        public static IEnumerable GetFACPDCNTERecords(this SUR_P09_FACPSHPDCPSHFACPDCNTEED message)
        {
            object[] result = message.GetRecords("FACPDCNTERepetitionsUsed", "GetFACPDCNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FACPDCNTE Records from SUR_P09_FACPSHPDCPSHFACPDCNTEED
        /// </summary>
        public static List<SUR_P09_FACPDCNTE> GetAllFACPDCNTERecords(this SUR_P09_FACPSHPDCPSHFACPDCNTEED message)
        {
            return message.GetAllRecords<SUR_P09_FACPDCNTE>("FACPDCNTERepetitionsUsed", "GetFACPDCNTE");
        }

        /// <summary>
        /// Add a new SUR_P09_FACPSHPDCPSHFACPDCNTEED to FACPDCNTE
        /// </summary>
        public static SUR_P09_FACPDCNTE AddFACPDCNTE(this SUR_P09_FACPSHPDCPSHFACPDCNTEED message)
        {
            return message.GetFACPDCNTE(message.FACPDCNTERepetitionsUsed);
        }

        /// <summary>
        /// Get TCC Records from TCU_U10_TEST_CONFIGURATION
        /// </summary>
        public static IEnumerable GetTCCRecords(this TCU_U10_TEST_CONFIGURATION message)
        {
            object[] result = message.GetRecords("TCCRepetitionsUsed", "GetTCC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TCC Records from TCU_U10_TEST_CONFIGURATION
        /// </summary>
        public static List<TCC> GetAllTCCRecords(this TCU_U10_TEST_CONFIGURATION message)
        {
            return message.GetAllRecords<TCC>("TCCRepetitionsUsed", "GetTCC");
        }

        /// <summary>
        /// Add a new TCU_U10_TEST_CONFIGURATION to TCC
        /// </summary>
        public static TCC AddTCC(this TCU_U10_TEST_CONFIGURATION message)
        {
            return message.GetTCC(message.TCCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from VXR_V03_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this VXR_V03_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from VXR_V03_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this VXR_V03_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new VXR_V03_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this VXR_V03_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from VXR_V03_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this VXR_V03_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from VXR_V03_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this VXR_V03_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new VXR_V03_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this VXR_V03_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from VXU_V04_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this VXU_V04_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from VXU_V04_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this VXU_V04_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new VXU_V04_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this VXU_V04_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TQ2 Records from VXU_V04_TIMING
        /// </summary>
        public static IEnumerable GetTQ2Records(this VXU_V04_TIMING message)
        {
            object[] result = message.GetRecords("TQ2RepetitionsUsed", "GetTQ2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ2 Records from VXU_V04_TIMING
        /// </summary>
        public static List<TQ2> GetAllTQ2Records(this VXU_V04_TIMING message)
        {
            return message.GetAllRecords<TQ2>("TQ2RepetitionsUsed", "GetTQ2");
        }

        /// <summary>
        /// Add a new VXU_V04_TIMING to TQ2
        /// </summary>
        public static TQ2 AddTQ2(this VXU_V04_TIMING message)
        {
            return message.GetTQ2(message.TQ2RepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from VXX_V02_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this VXX_V02_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from VXX_V02_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this VXX_V02_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new VXX_V02_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this VXX_V02_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }
        #endregion
    }
}
