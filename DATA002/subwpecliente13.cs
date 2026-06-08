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
   public class subwpecliente13 : GXSubfileElement
   {
      private String VEditar ;
      private String VExcluir ;
      private int PesCodigo ;
      private String PesNome ;
      private int PesDepTotal ;
      private short PesSituacao ;
      private String PesSituacaoDescription ;
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

      public int getPesDepTotal( )
      {
         return PesDepTotal ;
      }

      public void setPesDepTotal( int value )
      {
         PesDepTotal = value;
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

      public override void clear( )
      {
         VEditar = "" ;
         VExcluir = "" ;
         PesCodigo = 0 ;
         PesNome = "" ;
         PesDepTotal = 0 ;
         PesSituacao = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVEditar().CompareTo(((subwpecliente13) element).getVEditar()) ;
               case 1 :
                  return  getVExcluir().CompareTo(((subwpecliente13) element).getVExcluir()) ;
               case 2 :
                  if ( getPesCodigo() > ((subwpecliente13) element).getPesCodigo() ) return 1;
                  if ( getPesCodigo() < ((subwpecliente13) element).getPesCodigo() ) return -1;
                  return 0;
               case 3 :
                  return  getPesNome().CompareTo(((subwpecliente13) element).getPesNome()) ;
               case 4 :
                  if ( getPesDepTotal() > ((subwpecliente13) element).getPesDepTotal() ) return 1;
                  if ( getPesDepTotal() < ((subwpecliente13) element).getPesDepTotal() ) return -1;
                  return 0;
               case 5 :
                  if ( getPesSituacao() > ((subwpecliente13) element).getPesSituacao() ) return 1;
                  if ( getPesSituacao() < ((subwpecliente13) element).getPesSituacao() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesCodigo() == 0 ) && ( String.CompareOrdinal(getPesNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesDepTotal() == 0 ) && ( getPesSituacao() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getVEditar() );
               break;
            case 1 :
               cell.setValue( getVExcluir() );
               break;
            case 2 :
               cell.setValue( getPesCodigo() );
               break;
            case 3 :
               cell.setValue( getPesNome() );
               break;
            case 4 :
               cell.setValue( getPesDepTotal() );
               break;
            case 5 :
               cell.setValue( getPesSituacao() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 5 :
               return getPesSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVEditar()) == 0) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVExcluir()) == 0) );
            case 2 :
               return ( (((GUIObjectInt) cell).getValue() == getPesCodigo()) );
            case 3 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesNome()) == 0) );
            case 4 :
               return ( (((GUIObjectInt) cell).getValue() == getPesDepTotal()) );
            case 5 :
               return ( (((GUIObjectShort) cell).getValue() == getPesSituacao()) );
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
                  setPesCodigo(value.getIntValue());
                  break;
               case 3 :
                  setPesNome(value.getStringValue());
                  break;
               case 4 :
                  setPesDepTotal(value.getIntValue());
                  break;
               case 5 :
                  setPesSituacao(value.getShortValue());
                  setPesSituacaoDescription( value.getText());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setVEditar(((subwpecliente13) element).getVEditar());
                  return;
               case 1 :
                  setVExcluir(((subwpecliente13) element).getVExcluir());
                  return;
               case 2 :
                  setPesCodigo(((subwpecliente13) element).getPesCodigo());
                  return;
               case 3 :
                  setPesNome(((subwpecliente13) element).getPesNome());
                  return;
               case 4 :
                  setPesDepTotal(((subwpecliente13) element).getPesDepTotal());
                  return;
               case 5 :
                  setPesSituacao(((subwpecliente13) element).getPesSituacao());
                  setPesSituacaoDescription(((subwpecliente13) element).getPesSituacaoDescription());
                  return;
         }
      }

   }

}
