using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtSDTFilDevolucao_SDTFilDevolucaoItem : GxUserType
   {
      public SdtSDTFilDevolucao_SDTFilDevolucaoItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDTFilDevolucao_SDTFilDevolucaoItem( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError ;
         GXSoapError = 1 ;
         sTagName = oReader.Name ;
         GXSoapError = oReader.Read() ;
         nOutParmCount = 0 ;
         while ( ( ( String.CompareOrdinal(oReader.Name.TrimEnd(' '), sTagName.TrimEnd(' ') ) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
         {
            readOk = 0 ;
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "FilDevLocMidFilCodigo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilcodigo = (int)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "FilDevLocMidFilNome".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilnome = oReader.Value ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "FilDevTotDevolucao".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevtotdevolucao = (long)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            GXSoapError = oReader.Read() ;
            nOutParmCount = (short)(nOutParmCount+1) ;
            if ( ( readOk == 0 ) )
            {
               context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( ) ;
               GXSoapError = (short)(nOutParmCount*-1) ;
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         short GXSoapError ;
         if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sName).TrimEnd(' ') )==0)) )
         {
            sName = "SDTFilDevolucao.SDTFilDevolucaoItem" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sNameSpace).TrimEnd(' ') )==0)) && ( String.CompareOrdinal(sNameSpace.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) != 0 ) )
         {
            oWriter.WriteStartElement(sName+"ns:"+sName);
            oWriter.WriteAttribute("xmlns:"+sName+"ns", sNameSpace);
         }
         else
         {
            oWriter.WriteStartElement(sName);
         }
         if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sNameSpace).TrimEnd(' ') )==0)) || ( String.CompareOrdinal(sNameSpace.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) != 0 ) )
         {
            oWriter.WriteAttribute("xmlns", "AgoraVaiCurso");
         }
         oWriter.WriteElement("FilDevLocMidFilCodigo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilcodigo), 9, 0)));
         oWriter.WriteElement("FilDevLocMidFilNome", StringUtil.RTrim( gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilnome));
         oWriter.WriteElement("FilDevTotDevolucao", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevtotdevolucao), 10, 0)));
         oWriter.WriteEndElement();
         return  ;
      }

      public int gxTpr_Fildevlocmidfilcodigo
      {
         get {
            return gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilcodigo ;
         }

         set {
            gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilcodigo = (int)(value) ;
         }

      }

      public void gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilcodigo_SetNull( )
      {
         gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilcodigo = 0 ;
         return  ;
      }

      public String gxTpr_Fildevlocmidfilnome
      {
         get {
            return gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilnome ;
         }

         set {
            gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilnome = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilnome_SetNull( )
      {
         gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilnome = "" ;
         return  ;
      }

      public long gxTpr_Fildevtotdevolucao
      {
         get {
            return gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevtotdevolucao ;
         }

         set {
            gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevtotdevolucao = (long)(value) ;
         }

      }

      public void gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevtotdevolucao_SetNull( )
      {
         gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevtotdevolucao = 0 ;
         return  ;
      }

      public void initialize( )
      {
         gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilcodigo = 0 ;
         gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilnome = "" ;
         gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevtotdevolucao = 0 ;
         sTagName = "" ;
         nOutParmCount = 0 ;
         readOk = 0 ;
         GXt_char1 = "" ;
         return  ;
      }

      private short nOutParmCount ;
      private short readOk ;
      private int gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilcodigo ;
      private long gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevtotdevolucao ;
      private String sTagName ;
      private String GXt_char1 ;
      private String gxTv_SdtSDTFilDevolucao_SDTFilDevolucaoItem_Fildevlocmidfilnome ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
      private bool IsMain ;
   }

}
