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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class subwpecidade02 : GXSubfileElement
   {
      private String VVisualizar ;
      private String VEditar ;
      private String VExcluir ;
      private String EstUF ;
      private int CidCodigo ;
      private String CidNome ;
      public String getVVisualizar( )
      {
         return VVisualizar ;
      }

      public void setVVisualizar( String value )
      {
         VVisualizar = value;
      }

      public String getVEditar( )
      {
         return VEditar ;
      }

      public void setVEditar( String value )
      {
         VEditar = value;
      }

      public String getVExcluir( )
      {
         return VExcluir ;
      }

      public void setVExcluir( String value )
      {
         VExcluir = value;
      }

      public String getEstUF( )
      {
         return EstUF ;
      }

      public void setEstUF( String value )
      {
         EstUF = value;
      }

      public int getCidCodigo( )
      {
         return CidCodigo ;
      }

      public void setCidCodigo( int value )
      {
         CidCodigo = value;
      }

      public String getCidNome( )
      {
         return CidNome ;
      }

      public void setCidNome( String value )
      {
         CidNome = value;
      }

      public override void clear( )
      {
         VVisualizar = "" ;
         VEditar = "" ;
         VExcluir = "" ;
         EstUF = "" ;
         CidCodigo = 0 ;
         CidNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVVisualizar().CompareTo(((subwpecidade02) element).getVVisualizar()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpecidade02) element).getVEditar()) ;
               case 2 :
                  return  getVExcluir().CompareTo(((subwpecidade02) element).getVExcluir()) ;
               case 3 :
                  return  getEstUF().CompareTo(((subwpecidade02) element).getEstUF()) ;
               case 4 :
                  if ( getCidCodigo() > ((subwpecidade02) element).getCidCodigo() ) return 1;
                  if ( getCidCodigo() < ((subwpecidade02) element).getCidCodigo() ) return -1;
                  return 0;
               case 5 :
                  return  getCidNome().CompareTo(((subwpecidade02) element).getCidNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getEstUF().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getCidCodigo() == 0 ) && ( String.CompareOrdinal(getCidNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getVVisualizar() );
               break;
            case 1 :
               cell.setValue( getVEditar() );
               break;
            case 2 :
               cell.setValue( getVExcluir() );
               break;
            case 3 :
               cell.setValue( getEstUF() );
               break;
            case 4 :
               cell.setValue( getCidCodigo() );
               break;
            case 5 :
               cell.setValue( getCidNome() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVVisualizar()) == 0) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVEditar()) == 0) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVExcluir()) == 0) );
            case 3 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getEstUF()) == 0) );
            case 4 :
               return ( (((GUIObjectInt) cell).getValue() == getCidCodigo()) );
            case 5 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getCidNome()) == 0) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  break;
               case 1 :
                  break;
               case 2 :
                  break;
               case 3 :
                  setEstUF(value.getStringValue());
                  break;
               case 4 :
                  setCidCodigo(value.getIntValue());
                  break;
               case 5 :
                  setCidNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setVVisualizar(((subwpecidade02) element).getVVisualizar());
                  return;
               case 1 :
                  setVEditar(((subwpecidade02) element).getVEditar());
                  return;
               case 2 :
                  setVExcluir(((subwpecidade02) element).getVExcluir());
                  return;
               case 3 :
                  setEstUF(((subwpecidade02) element).getEstUF());
                  return;
               case 4 :
                  setCidCodigo(((subwpecidade02) element).getCidCodigo());
                  return;
               case 5 :
                  setCidNome(((subwpecidade02) element).getCidNome());
                  return;
         }
      }

   }

}
