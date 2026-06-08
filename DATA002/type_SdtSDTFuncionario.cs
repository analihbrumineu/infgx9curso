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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtSDTFuncionario : GxUserType
   {
      public SdtSDTFuncionario( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDTFuncionario( IGxContext context )
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
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "PesCodigo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFuncionario_Pescodigo = (int)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "PesFunCargo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFuncionario_Pesfuncargo = (short)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "PesFunLogin".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFuncionario_Pesfunlogin = oReader.Value ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "PesFunSenha".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFuncionario_Pesfunsenha = oReader.Value ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "FoiLogado".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFuncionario_Foilogado = oReader.Value ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "PesNome".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTFuncionario_Pesnome = oReader.Value ;
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
            sName = "SDTFuncionario" ;
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
         oWriter.WriteElement("PesCodigo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTFuncionario_Pescodigo), 9, 0)));
         oWriter.WriteElement("PesFunCargo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTFuncionario_Pesfuncargo), 1, 0)));
         oWriter.WriteElement("PesFunLogin", StringUtil.RTrim( gxTv_SdtSDTFuncionario_Pesfunlogin));
         oWriter.WriteElement("PesFunSenha", StringUtil.RTrim( gxTv_SdtSDTFuncionario_Pesfunsenha));
         oWriter.WriteElement("FoiLogado", StringUtil.RTrim( gxTv_SdtSDTFuncionario_Foilogado));
         oWriter.WriteElement("PesNome", StringUtil.RTrim( gxTv_SdtSDTFuncionario_Pesnome));
         oWriter.WriteEndElement();
         return  ;
      }

      public int gxTpr_Pescodigo
      {
         get {
            return gxTv_SdtSDTFuncionario_Pescodigo ;
         }

         set {
            gxTv_SdtSDTFuncionario_Pescodigo = (int)(value) ;
         }

      }

      public void gxTv_SdtSDTFuncionario_Pescodigo_SetNull( )
      {
         gxTv_SdtSDTFuncionario_Pescodigo = 0 ;
         return  ;
      }

      public short gxTpr_Pesfuncargo
      {
         get {
            return gxTv_SdtSDTFuncionario_Pesfuncargo ;
         }

         set {
            gxTv_SdtSDTFuncionario_Pesfuncargo = (short)(value) ;
         }

      }

      public void gxTv_SdtSDTFuncionario_Pesfuncargo_SetNull( )
      {
         gxTv_SdtSDTFuncionario_Pesfuncargo = 0 ;
         return  ;
      }

      public String gxTpr_Pesfunlogin
      {
         get {
            return gxTv_SdtSDTFuncionario_Pesfunlogin ;
         }

         set {
            gxTv_SdtSDTFuncionario_Pesfunlogin = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTFuncionario_Pesfunlogin_SetNull( )
      {
         gxTv_SdtSDTFuncionario_Pesfunlogin = "" ;
         return  ;
      }

      public String gxTpr_Pesfunsenha
      {
         get {
            return gxTv_SdtSDTFuncionario_Pesfunsenha ;
         }

         set {
            gxTv_SdtSDTFuncionario_Pesfunsenha = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTFuncionario_Pesfunsenha_SetNull( )
      {
         gxTv_SdtSDTFuncionario_Pesfunsenha = "" ;
         return  ;
      }

      public String gxTpr_Foilogado
      {
         get {
            return gxTv_SdtSDTFuncionario_Foilogado ;
         }

         set {
            gxTv_SdtSDTFuncionario_Foilogado = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTFuncionario_Foilogado_SetNull( )
      {
         gxTv_SdtSDTFuncionario_Foilogado = "" ;
         return  ;
      }

      public String gxTpr_Pesnome
      {
         get {
            return gxTv_SdtSDTFuncionario_Pesnome ;
         }

         set {
            gxTv_SdtSDTFuncionario_Pesnome = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTFuncionario_Pesnome_SetNull( )
      {
         gxTv_SdtSDTFuncionario_Pesnome = "" ;
         return  ;
      }

      public void initialize( )
      {
         gxTv_SdtSDTFuncionario_Pescodigo = 0 ;
         gxTv_SdtSDTFuncionario_Pesfuncargo = 0 ;
         gxTv_SdtSDTFuncionario_Pesfunlogin = "" ;
         gxTv_SdtSDTFuncionario_Pesfunsenha = "" ;
         gxTv_SdtSDTFuncionario_Foilogado = "" ;
         gxTv_SdtSDTFuncionario_Pesnome = "" ;
         sTagName = "" ;
         nOutParmCount = 0 ;
         readOk = 0 ;
         GXt_char1 = "" ;
         return  ;
      }

      private short gxTv_SdtSDTFuncionario_Pesfuncargo ;
      private short nOutParmCount ;
      private short readOk ;
      private int gxTv_SdtSDTFuncionario_Pescodigo ;
      private String gxTv_SdtSDTFuncionario_Foilogado ;
      private String sTagName ;
      private String GXt_char1 ;
      private String gxTv_SdtSDTFuncionario_Pesfunlogin ;
      private String gxTv_SdtSDTFuncionario_Pesfunsenha ;
      private String gxTv_SdtSDTFuncionario_Pesnome ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
      private bool IsMain ;
   }

}
