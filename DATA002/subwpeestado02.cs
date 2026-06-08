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
   public class subwpeestado02 : GXSubfileElement
   {
      private String VVisualizar ;
      private String VEditar ;
      private String VExcluir ;
      private int EstCodigo ;
      private String EstUF ;
      private String EstNome ;
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

      public int getEstCodigo( )
      {
         return EstCodigo ;
      }

      public void setEstCodigo( int value )
      {
         EstCodigo = value;
      }

      public String getEstUF( )
      {
         return EstUF ;
      }

      public void setEstUF( String value )
      {
         EstUF = value;
      }

      public String getEstNome( )
      {
         return EstNome ;
      }

      public void setEstNome( String value )
      {
         EstNome = value;
      }

      public override void clear( )
      {
         VVisualizar = "" ;
         VEditar = "" ;
         VExcluir = "" ;
         EstCodigo = 0 ;
         EstUF = "" ;
         EstNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVVisualizar().CompareTo(((subwpeestado02) element).getVVisualizar()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpeestado02) element).getVEditar()) ;
               case 2 :
                  return  getVExcluir().CompareTo(((subwpeestado02) element).getVExcluir()) ;
               case 3 :
                  if ( getEstCodigo() > ((subwpeestado02) element).getEstCodigo() ) return 1;
                  if ( getEstCodigo() < ((subwpeestado02) element).getEstCodigo() ) return -1;
                  return 0;
               case 4 :
                  return  getEstUF().CompareTo(((subwpeestado02) element).getEstUF()) ;
               case 5 :
                  return  getEstNome().CompareTo(((subwpeestado02) element).getEstNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getEstCodigo() == 0 ) && ( String.CompareOrdinal(getEstUF().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getEstNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
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
               cell.setValue( getEstCodigo() );
               break;
            case 4 :
               cell.setValue( getEstUF() );
               break;
            case 5 :
               cell.setValue( getEstNome() );
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
               return ( (((GUIObjectInt) cell).getValue() == getEstCodigo()) );
            case 4 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getEstUF()) == 0) );
            case 5 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getEstNome()) == 0) );
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
                  setEstCodigo(value.getIntValue());
                  break;
               case 4 :
                  setEstUF(value.getStringValue());
                  break;
               case 5 :
                  setEstNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setVVisualizar(((subwpeestado02) element).getVVisualizar());
                  return;
               case 1 :
                  setVEditar(((subwpeestado02) element).getVEditar());
                  return;
               case 2 :
                  setVExcluir(((subwpeestado02) element).getVExcluir());
                  return;
               case 3 :
                  setEstCodigo(((subwpeestado02) element).getEstCodigo());
                  return;
               case 4 :
                  setEstUF(((subwpeestado02) element).getEstUF());
                  return;
               case 5 :
                  setEstNome(((subwpeestado02) element).getEstNome());
                  return;
         }
      }

   }

}
