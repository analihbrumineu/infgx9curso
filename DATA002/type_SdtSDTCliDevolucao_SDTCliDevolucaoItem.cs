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
   public class SdtSDTCliDevolucao_SDTCliDevolucaoItem : GxUserType
   {
      public SdtSDTCliDevolucao_SDTCliDevolucaoItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDTCliDevolucao_SDTCliDevolucaoItem( IGxContext context )
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
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CliDevLocCliPesCodigo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipescodigo = (int)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CliDevLocCliPesNome".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipesnome = oReader.Value ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CliDevTotDevolucao".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevtotdevolucao = (long)(NumberUtil.Val( oReader.Value, true)) ;
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
            sName = "SDTCliDevolucao.SDTCliDevolucaoItem" ;
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
         oWriter.WriteElement("CliDevLocCliPesCodigo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipescodigo), 9, 0)));
         oWriter.WriteElement("CliDevLocCliPesNome", StringUtil.RTrim( gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipesnome));
         oWriter.WriteElement("CliDevTotDevolucao", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevtotdevolucao), 10, 0)));
         oWriter.WriteEndElement();
         return  ;
      }

      public int gxTpr_Clidevlocclipescodigo
      {
         get {
            return gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipescodigo ;
         }

         set {
            gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipescodigo = (int)(value) ;
         }

      }

      public void gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipescodigo_SetNull( )
      {
         gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipescodigo = 0 ;
         return  ;
      }

      public String gxTpr_Clidevlocclipesnome
      {
         get {
            return gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipesnome ;
         }

         set {
            gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipesnome = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipesnome_SetNull( )
      {
         gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipesnome = "" ;
         return  ;
      }

      public long gxTpr_Clidevtotdevolucao
      {
         get {
            return gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevtotdevolucao ;
         }

         set {
            gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevtotdevolucao = (long)(value) ;
         }

      }

      public void gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevtotdevolucao_SetNull( )
      {
         gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevtotdevolucao = 0 ;
         return  ;
      }

      public void initialize( )
      {
         gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipescodigo = 0 ;
         gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipesnome = "" ;
         gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevtotdevolucao = 0 ;
         sTagName = "" ;
         nOutParmCount = 0 ;
         readOk = 0 ;
         GXt_char1 = "" ;
         return  ;
      }

      private short nOutParmCount ;
      private short readOk ;
      private int gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipescodigo ;
      private long gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevtotdevolucao ;
      private String sTagName ;
      private String GXt_char1 ;
      private String gxTv_SdtSDTCliDevolucao_SDTCliDevolucaoItem_Clidevlocclipesnome ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
      private bool IsMain ;
   }

}
