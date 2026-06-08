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
   public class subwpecliente11 : GXSubfileElement
   {
      private String VVisualizar ;
      private String VEditar ;
      private String VExcluir ;
      private int PesCodigo ;
      private String PesNome ;
      private int PesDepTotal ;
      private short PesSituacao ;
      private String PesSituacaoDescription ;
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
         VVisualizar = "" ;
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
                  return  getVVisualizar().CompareTo(((subwpecliente11) element).getVVisualizar()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpecliente11) element).getVEditar()) ;
               case 2 :
                  return  getVExcluir().CompareTo(((subwpecliente11) element).getVExcluir()) ;
               case 3 :
                  if ( getPesCodigo() > ((subwpecliente11) element).getPesCodigo() ) return 1;
                  if ( getPesCodigo() < ((subwpecliente11) element).getPesCodigo() ) return -1;
                  return 0;
               case 4 :
                  return  getPesNome().CompareTo(((subwpecliente11) element).getPesNome()) ;
               case 5 :
                  if ( getPesDepTotal() > ((subwpecliente11) element).getPesDepTotal() ) return 1;
                  if ( getPesDepTotal() < ((subwpecliente11) element).getPesDepTotal() ) return -1;
                  return 0;
               case 6 :
                  if ( getPesSituacao() > ((subwpecliente11) element).getPesSituacao() ) return 1;
                  if ( getPesSituacao() < ((subwpecliente11) element).getPesSituacao() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesCodigo() == 0 ) && ( String.CompareOrdinal(getPesNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesDepTotal() == 0 ) && ( getPesSituacao() == 0 ) )  ;
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
               cell.setValue( getPesCodigo() );
               break;
            case 4 :
               cell.setValue( getPesNome() );
               break;
            case 5 :
               cell.setValue( getPesDepTotal() );
               break;
            case 6 :
               cell.setValue( getPesSituacao() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 6 :
               return getPesSituacaoDescription() ;
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
               return ( (((GUIObjectInt) cell).getValue() == getPesCodigo()) );
            case 4 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesNome()) == 0) );
            case 5 :
               return ( (((GUIObjectInt) cell).getValue() == getPesDepTotal()) );
            case 6 :
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
                  break;
               case 3 :
                  setPesCodigo(value.getIntValue());
                  break;
               case 4 :
                  setPesNome(value.getStringValue());
                  break;
               case 5 :
                  setPesDepTotal(value.getIntValue());
                  break;
               case 6 :
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
                  setVVisualizar(((subwpecliente11) element).getVVisualizar());
                  return;
               case 1 :
                  setVEditar(((subwpecliente11) element).getVEditar());
                  return;
               case 2 :
                  setVExcluir(((subwpecliente11) element).getVExcluir());
                  return;
               case 3 :
                  setPesCodigo(((subwpecliente11) element).getPesCodigo());
                  return;
               case 4 :
                  setPesNome(((subwpecliente11) element).getPesNome());
                  return;
               case 5 :
                  setPesDepTotal(((subwpecliente11) element).getPesDepTotal());
                  return;
               case 6 :
                  setPesSituacao(((subwpecliente11) element).getPesSituacao());
                  setPesSituacaoDescription(((subwpecliente11) element).getPesSituacaoDescription());
                  return;
         }
      }

   }

}
