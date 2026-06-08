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
   public class subwconscliente10 : GXSubfileElement
   {
      private int PesCodigo ;
      private String PesNome ;
      private String PesBairro ;
      private short PesSituacao ;
      private String PesSituacaoDescription ;
      private int PesDepTotal ;
      public int getPesCodigo( )
      {
         return PesCodigo ;
      }

      public void setPesCodigo( int value )
      {
         PesCodigo = value;
      }

      public String getPesNome( )
      {
         return PesNome ;
      }

      public void setPesNome( String value )
      {
         PesNome = value;
      }

      public String getPesBairro( )
      {
         return PesBairro ;
      }

      public void setPesBairro( String value )
      {
         PesBairro = value;
      }

      public short getPesSituacao( )
      {
         return PesSituacao ;
      }

      public void setPesSituacao( short value )
      {
         PesSituacao = value;
      }

      public String getPesSituacaoDescription( )
      {
         return PesSituacaoDescription ;
      }

      public void setPesSituacaoDescription( String value )
      {
         PesSituacaoDescription = value;
      }

      public int getPesDepTotal( )
      {
         return PesDepTotal ;
      }

      public void setPesDepTotal( int value )
      {
         PesDepTotal = value;
      }

      public override void clear( )
      {
         PesCodigo = 0 ;
         PesNome = "" ;
         PesBairro = "" ;
         PesSituacao = 0 ;
         PesDepTotal = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getPesCodigo() > ((subwconscliente10) element).getPesCodigo() ) return 1;
                  if ( getPesCodigo() < ((subwconscliente10) element).getPesCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getPesNome().CompareTo(((subwconscliente10) element).getPesNome()) ;
               case 2 :
                  return  getPesBairro().CompareTo(((subwconscliente10) element).getPesBairro()) ;
               case 3 :
                  if ( getPesSituacao() > ((subwconscliente10) element).getPesSituacao() ) return 1;
                  if ( getPesSituacao() < ((subwconscliente10) element).getPesSituacao() ) return -1;
                  return 0;
               case 4 :
                  if ( getPesDepTotal() > ((subwconscliente10) element).getPesDepTotal() ) return 1;
                  if ( getPesDepTotal() < ((subwconscliente10) element).getPesDepTotal() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getPesCodigo() == 0 ) && ( String.CompareOrdinal(getPesNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getPesBairro().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesSituacao() == 0 ) && ( getPesDepTotal() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getPesCodigo() );
               break;
            case 1 :
               cell.setValue( getPesNome() );
               break;
            case 2 :
               cell.setValue( getPesBairro() );
               break;
            case 3 :
               cell.setValue( getPesSituacao() );
               break;
            case 4 :
               cell.setValue( getPesDepTotal() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 3 :
               return getPesSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getPesCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesNome()) == 0) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesBairro()) == 0) );
            case 3 :
               return ( (((GUIObjectShort) cell).getValue() == getPesSituacao()) );
            case 4 :
               return ( (((GUIObjectInt) cell).getValue() == getPesDepTotal()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setPesCodigo(value.getIntValue());
                  break;
               case 1 :
                  setPesNome(value.getStringValue());
                  break;
               case 2 :
                  setPesBairro(value.getStringValue());
                  break;
               case 3 :
                  setPesSituacao(value.getShortValue());
                  setPesSituacaoDescription( value.getText());
                  break;
               case 4 :
                  setPesDepTotal(value.getIntValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setPesCodigo(((subwconscliente10) element).getPesCodigo());
                  return;
               case 1 :
                  setPesNome(((subwconscliente10) element).getPesNome());
                  return;
               case 2 :
                  setPesBairro(((subwconscliente10) element).getPesBairro());
                  return;
               case 3 :
                  setPesSituacao(((subwconscliente10) element).getPesSituacao());
                  setPesSituacaoDescription(((subwconscliente10) element).getPesSituacaoDescription());
                  return;
               case 4 :
                  setPesDepTotal(((subwconscliente10) element).getPesDepTotal());
                  return;
         }
      }

   }

}
