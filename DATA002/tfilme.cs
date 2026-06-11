/*
               File: Filme
        Description: Cadastro de filmes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 11:31:29.50
       Program type: Callable routine
          Main DBMS: sqlserver
*/
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
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   /* Client and Server side code */
   public class tfilme : GXTransaction
   {
      public tfilme( int hnd ,
                     ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tfilme( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tfilme( IGxContext context ,
                     int hnd ,
                     ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey023( )
      {
         A29FilNome = "" ;
         n29FilNome = false ;
         n29FilNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A29FilNome).TrimEnd(' ') )==0)) ? true : false) ;
         A30FilSitu = 1 ;
         n30FilSitu = false ;
         A31FilData = Gx_date ;
         n31FilData = false ;
         A32CatCodi = 0 ;
         n32CatCodi = false ;
         n32CatCodi = (((0==A32CatCodi)) ? true : false) ;
         A33CatNome = "" ;
         n33CatNome = false ;
         A34FilDesc = "" ;
         n34FilDesc = false ;
         n34FilDesc = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A34FilDesc).TrimEnd(' ') )==0)) ? true : false) ;
         A55FilOsca = 0 ;
         n55FilOsca = false ;
      }

      protected void InitAll023( )
      {
         K28FilCodi = A28FilCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey023( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A31FilData = i31FilData ;
         edtFilData.setValue(A31FilData);
         n31FilData = false ;
         A30FilSitu = i30FilSitu ;
         cmbFilSituacao.setValue(A30FilSitu);
         n30FilSitu = false ;
      }

      protected void InitializeNonKey024( )
      {
      }

      protected void InitAll024( )
      {
         A79FilDirC = 0 ;
         A80FilDirN = "" ;
         n80FilDirN = false ;
         K79FilDirC = A79FilDirC ;
         geteqAfterKey4 = 1 ;
         InitializeNonKey024( ) ;
      }

      protected void StandaloneModalInsert024( )
      {
      }

      protected void InitializeNonKey025( )
      {
         A81FilAtoP = 0 ;
         n81FilAtoP = false ;
      }

      protected void InitAll025( )
      {
         A77FilAtoC = 0 ;
         A78FilAtoN = "" ;
         n78FilAtoN = false ;
         K77FilAtoC = A77FilAtoC ;
         geteqAfterKey5 = 1 ;
         InitializeNonKey025( ) ;
      }

      protected void StandaloneModalInsert025( )
      {
      }

      protected void ResetCaption020( )
      {
      }

      /* Client side code */
      public override void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
      }

      public override String getObjectName( )
      {
         return "Filme" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de filmes" ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return null;
      }

      public override bool useCallersMenuBar( )
      {
         return true;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 563 ;
      }

      public override int getFrmHeight( )
      {
         return 774 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TFilme.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return IsMain;
      }

      public override bool isModal( )
      {
         return true ;
      }

      protected bool hasDBAccess( )
      {
         return true ;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public void execute( int aP0_FilCodigo ,
                           String aP1_Gx_mode )
      {
         this.A28FilCodi = aP0_FilCodigo;
         this.Gx_mode = aP1_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 563 , 774 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Cadastrar" ,  445 ,  731 ,  89 ,  27 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Cadastrar");
         bttBtn_enter.addActionListener(this);
         tctrlCadastrodefilme = new GXTabControl (this,  GXPanel1 , 0 , 0 , 563 , 709 , UIFactory.getColor(5) , UIFactory.getColor(8) , 0, 0, 0, false );
         tpagetpage3 = new GXTabPage ( tctrlCadastrodefilme , "Filme" , 5 , 29 , 558 , 680 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         edtFilCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),168, 92, 65, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 168 , 92 , 65 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A28FilCodi" );
         ((GXEdit) edtFilCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtFilCodigo.addFocusListener(this);
         edtFilCodigo.getGXComponent().setHelpId("HLP_TFilme.htm");
         cmbFilSituacao = new GUIObjectShort ( new GXComboBox(tpagetpage3.getGXPanel()) , tpagetpage3.getGXPanel() , 168 , 116 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A30FilSitu" );
         ((GXComboBox) cmbFilSituacao.getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) cmbFilSituacao.getGXComponent()).addItem( new java.lang.Short(0),"Inativo");
         cmbFilSituacao.addFocusListener(this);
         cmbFilSituacao.addItemListener(this);
         cmbFilSituacao.getGXComponent().setHelpId("HLP_TFilme.htm");
         edtFilData = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),168, 141, 104, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 168 , 141 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A31FilData" );
         ((GXEdit) edtFilData.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtFilData.addFocusListener(this);
         edtFilData.getGXComponent().setHelpId("HLP_TFilme.htm");
         edtCatCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),168, 166, 65, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(255, 255, 255), false) , tpagetpage3.getGXPanel() , 168 , 166 , 65 , 21 , UIFactory.getColor(255, 255, 255) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A32CatCodi" );
         ((GXEdit) edtCatCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtCatCodigo.addFocusListener(this);
         edtCatCodigo.getGXComponent().setHelpId("HLP_TFilme.htm");
         edtCatNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),242, 166, 169, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 242 , 166 , 169 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A33CatNome" );
         ((GXEdit) edtCatNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtCatNome.addFocusListener(this);
         edtCatNome.getGXComponent().setHelpId("HLP_TFilme.htm");
         edtFilNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),168, 191, 266, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 168 , 191 , 266 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A29FilNome" );
         ((GXEdit) edtFilNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtFilNome.addFocusListener(this);
         edtFilNome.getGXComponent().setHelpId("HLP_TFilme.htm");
         edtFilDescricao = new GUIObjectString ( new GXEdit(800, "@!", UIFactory.getFont( "Courier New", 0, 9),168, 216, 364, 373, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.LONGVARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 168 , 216 , 364 , 373 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A34FilDesc" );
         ((GXEdit) edtFilDescricao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtFilDescricao.addFocusListener(this);
         edtFilDescricao.getGXComponent().setHelpId("HLP_TFilme.htm");
         chkFilOscar = new GUIObjectShort ( new GXCheckBox(tpagetpage3.getGXPanel(), "Vencedor do Oscar" , new java.lang.Short(1), new java.lang.Short(0)) , tpagetpage3.getGXPanel() , 168 , 593 , 140 , 16 , Integer.MAX_VALUE , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A55FilOsca" );
         chkFilOscar.addFocusListener(this);
         chkFilOscar.addItemListener(this);
         chkFilOscar.getGXComponent().setHelpId("HLP_TFilme.htm");
         lbllbl15 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Dados gerais", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 26 , 75 , 13 );
         lbllbl5 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 107 , 96 , 40 , 13 );
         lbllbl9 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 96 , 120 , 51 , 13 );
         lbllbl7 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Estreia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 107 , 144 , 40 , 13 );
         lbllbl18 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 92 , 170 , 55 , 13 );
         lbllbl11 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Título", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 112 , 195 , 35 , 13 );
         lbllbl12 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Descrição", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 89 , 216 , 58 , 13 );
         tpagetpage19 = new GXTabPage ( tctrlCadastrodefilme , "Direção" , 5 , 29 , 558 , 680 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         addSubfile ( subGxsf21  = new GXSubfileTRN ( new Filme_flow21(this) , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 103, 19, tpagetpage19.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 102 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A79FilDirC" ), "Código"  , UIFactory.getColor(8) , UIFactory.getColor(15) , 102 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 213, 19, tpagetpage19.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 212 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A80FilDirN" ), "Nome completo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 212 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 31 , 18 , tpagetpage19.getGXPanel() , 37 , 52 , 372 , 592 ,  18 ));
         subGxsf21.addActionListener(this);
         subGxsf21.addFocusListener(this);
         subGxsf21.setSortOnClick(false);
         lbllbl20 = UIFactory.getLabel(tpagetpage19.getGXPanel(), "Direção", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 26 , 45 , 13 );
         tpagetpage24 = new GXTabPage ( tctrlCadastrodefilme , "Elenco" , 5 , 29 , 558 , 680 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         addSubfile ( subGxsf26  = new GXSubfileTRN ( new Filme_flow26(this) , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 84, 19, tpagetpage24.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 83 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A77FilAtoC" ), "Código"  , UIFactory.getColor(8) , UIFactory.getColor(15) , 83 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 202, 19, tpagetpage24.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 201 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A78FilAtoN" ), "Nome completo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 201 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXCheckBox(tpagetpage24.getGXPanel(), "" , new java.lang.Short(1), new java.lang.Short(0)) , null ,  0 , 0 , 79 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A81FilAtoP" ), "Protagonista"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 79 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         }, 32 , 18 , tpagetpage24.getGXPanel() , 39 , 52 , 422 , 593 ,  18 ));
         subGxsf26.addActionListener(this);
         subGxsf26.addFocusListener(this);
         subGxsf26.setSortOnClick(false);
         lbllbl25 = UIFactory.getLabel(tpagetpage24.getGXPanel(), "Atores", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 26 , 37 , 13 );
         subGxsf26.getColumn(0).addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         subGxsf21.getColumn(0).addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         edtCatCodigo.addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         focusManager.setControlList(new IFocusableControl[] {
                   edtFilCodigo ,
                   cmbFilSituacao ,
                   edtFilData ,
                   edtCatCodigo ,
                   edtCatNome ,
                   edtFilNome ,
                   edtFilDescricao ,
                   chkFilOscar ,
                   subGxsf21 ,
                   subGxsf26 ,
                   bttBtn_enter
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Filcodigo();
         setFocus(cmbFilSituacao, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey023( ) ;
         subGxsf21.startLoad();
         subtfilme21 = new subtfilme21 ();
         subGxsf21.endLoad();
         subGxsf26.startLoad();
         subtfilme26 = new subtfilme26 ();
         subGxsf26.endLoad();
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setGXEnabled(0);
            edtFilCodigo.setEnabled(0);
            edtFilData.setEnabled(0);
            cmbFilSituacao.setEnabled(0);
            edtFilNome.setEnabled(0);
            edtFilDescricao.setEnabled(0);
            chkFilOscar.setEnabled(0);
            edtCatCodigo.setEnabled(0);
            edtCatNome.setEnabled(0);
            subGxsf21.getColumn(0).setEnabled(0);
            subGxsf21.getColumn(1).setEnabled(0);
            subGxsf26.getColumn(0).setEnabled(0);
            subGxsf26.getColumn(1).setEnabled(0);
            subGxsf26.getColumn(2).setEnabled(0);
            setFocus(bttBtn_enter, true);
         }
      }

      public override void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               base.context.msgStatus(GXResourceManager.GetMessage("confdelete"));
            }
            else
            {
               base.context.msgStatus(GXResourceManager.GetMessage("mustconfirm"));
            }
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionconfirm"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionconfirm"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionadd"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionadd"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionupdate"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionupdate"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captiondelete"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captiondelete"));
         }
         else
         {
         }
      }

      protected void AfterTrn( )
      {
         if ( ( trnEnded == 1 ) )
         {
            /* Execute user event: E11022 */
            E11022 ();
            trnEnded = 0 ;
            if (!cleanedUp) {
               standaloneNotModal( ) ;
               standaloneModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  )
               {
                  /* Clear variables for new insertion. */
                  InitAll023( ) ;
                  standaloneNotModal( ) ;
                  standaloneModal( ) ;
               }
            }
         }
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public void loadToBuffer21( )
      {
         subtfilme21 oAux = subtfilme21 ;
         subtfilme21 = new subtfilme21 ();
         variablesToSubfile21 ();
         subGxsf21.addElement(subtfilme21);
         subtfilme21 = oAux;
      }

      public bool isLoadAtStartup_flow21( )
      {
         return false;
      }

      public void autoRefresh_flow21( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
      }

      public bool getSearch_flow21( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow21( )
      {
      }

      public void resetSearchConditions_flow21( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow21( )
      {
         if ( subGxsf21.getItemCount() > 0 )
         {
            subtfilme21 = ( subtfilme21 ) subGxsf21.getElementAt(subGxsf21.getItemCount() -1);
            subfileToVariables21 ();
            /* Save values for previous() function. */
         }
         subtfilme21 = new subtfilme21 ();
         InitAll024( ) ;
         sMode4 = Gx_mode ;
         Gx_mode = "INS" ;
         standaloneModal024( ) ;
         Gx_mode = sMode4 ;
         variablesToSubfile21 ();
         return subtfilme21 ;
      }

      public bool getSearch_flow21( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow21( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow21( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         String Gx_mode = element.getMode();
         subtfilme21 subtfilme21  = ( subtfilme21 ) element;
         if ( col == 0 )
         {
            return ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  );
         }
         return !enabled;
      }

      public void refresh_flow21( )
      {
      }

      public class Filme_flow21 : GXSubfileFlow
      {
         tfilme _sf ;

         public Filme_flow21( tfilme uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow21();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow21(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow21();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow21();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow21(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow21();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow21(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow21(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow21(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow21();
         }

      }

      public void loadToBuffer26( )
      {
         subtfilme26 oAux = subtfilme26 ;
         subtfilme26 = new subtfilme26 ();
         variablesToSubfile26 ();
         subGxsf26.addElement(subtfilme26);
         subtfilme26 = oAux;
      }

      public bool isLoadAtStartup_flow26( )
      {
         return false;
      }

      public void autoRefresh_flow26( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
      }

      public bool getSearch_flow26( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow26( )
      {
      }

      public void resetSearchConditions_flow26( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow26( )
      {
         if ( subGxsf26.getItemCount() > 0 )
         {
            subtfilme26 = ( subtfilme26 ) subGxsf26.getElementAt(subGxsf26.getItemCount() -1);
            subfileToVariables26 ();
            /* Save values for previous() function. */
         }
         subtfilme26 = new subtfilme26 ();
         InitAll025( ) ;
         sMode5 = Gx_mode ;
         Gx_mode = "INS" ;
         standaloneModal025( ) ;
         Gx_mode = sMode5 ;
         variablesToSubfile26 ();
         return subtfilme26 ;
      }

      public bool getSearch_flow26( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow26( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow26( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         String Gx_mode = element.getMode();
         subtfilme26 subtfilme26  = ( subtfilme26 ) element;
         if ( col == 0 )
         {
            return ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  );
         }
         return !enabled;
      }

      public void refresh_flow26( )
      {
      }

      public class Filme_flow26 : GXSubfileFlow
      {
         tfilme _sf ;

         public Filme_flow26( tfilme uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow26();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow26(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow26();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow26();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow26(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow26();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow26(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow26(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow26(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow26();
         }

      }

      public override void GXEnter( )
      {
         btn_enter( ) ;
         if (!cleanedUp) {
            VariablesToControls();
            set_caption( );
         }
      }

      public override void GXStart( )
      {
         standaloneStartup( ) ;
         VariablesToControls();
         /* Execute Start event if defined. */
         /* Execute user event: E12022 */
         E12022 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         lastAnyError = AnyError ;
         AnyError = 0;
         if ( bttBtn_enter.isEventSource(eventSource) ) {
            if ( ( lastAnyError != 0 ) )
            {
               return;
            }
            btn_enter( ) ;
            if (!cleanedUp) {
               VariablesToControls();
               set_caption( );
            }
            return;
         }
         if ( subGxsf21.isEventSource(eventSource) ) {
            GXEnter( );
            return;
         }
         if ( subGxsf26.isEventSource(eventSource) ) {
            GXEnter( );
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtFilCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtFilCodigo.getGXCursor() );
            return;
         }
         if ( edtFilData.isEventSource(eventSource) ) {
            setGXCursor( edtFilData.getGXCursor() );
            return;
         }
         if ( cmbFilSituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbFilSituacao.getGXCursor() );
            return;
         }
         if ( edtFilNome.isEventSource(eventSource) ) {
            setGXCursor( edtFilNome.getGXCursor() );
            return;
         }
         if ( edtFilDescricao.isEventSource(eventSource) ) {
            setGXCursor( edtFilDescricao.getGXCursor() );
            return;
         }
         if ( chkFilOscar.isEventSource(eventSource) ) {
            setGXCursor( chkFilOscar.getGXCursor() );
            return;
         }
         if ( edtCatCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtCatCodigo.getGXCursor() );
            return;
         }
         if ( edtCatNome.isEventSource(eventSource) ) {
            setGXCursor( edtCatNome.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( edtFilData.isEventSource(eventSource) ) {
            Valid_Fildata ();
            return;
         }
         if ( edtFilNome.isEventSource(eventSource) ) {
            Valid_Filnome ();
            return;
         }
         if ( edtCatCodigo.isEventSource(eventSource) ) {
            Valid_Catcodigo ();
            return;
         }
         if ( edtFilDescricao.isEventSource(eventSource) ) {
            Valid_Fildescricao ();
            return;
         }
         if ( edtFilCodigo.isEventSource(eventSource) ) {
            Valid_Filcodigo ();
            return;
         }
         if ( subGxsf21.getColumn(0).isEventSource(eventSource) ) {
            subtfilme21 = (subtfilme21)subGxsf21.cloneCurrentElement();
            if ( ( subtfilme21.isDeleted() != 1 ) )
            {
               subfileToVariables21 ();
               sMode4 = Gx_mode ;
               Gx_mode = (String)(subtfilme21.getTrnMode()) ;
               Valid_Fildircodigo ();
               Gx_mode = sMode4 ;
            }
            return;
         }
         if ( subGxsf26.getColumn(0).isEventSource(eventSource) ) {
            subtfilme26 = (subtfilme26)subGxsf26.cloneCurrentElement();
            if ( ( subtfilme26.isDeleted() != 1 ) )
            {
               subfileToVariables26 ();
               sMode5 = Gx_mode ;
               Gx_mode = (String)(subtfilme26.getTrnMode()) ;
               Valid_Filatocodigo ();
               Gx_mode = sMode5 ;
            }
            return;
         }
         if ( subGxsf21.getColumn(1).isEventSource(eventSource) ) {
            subtfilme21 = (subtfilme21)subGxsf21.cloneCurrentElement();
            if ( ( subtfilme21.isDeleted() != 1 ) )
            {
               subfileToVariables21 ();
               sMode4 = Gx_mode ;
               Gx_mode = (String)(subtfilme21.getTrnMode()) ;
               Valid_Fildirnome ();
               Gx_mode = sMode4 ;
            }
            return;
         }
         if ( subGxsf26.getColumn(2).isEventSource(eventSource) ) {
            subtfilme26 = (subtfilme26)subGxsf26.cloneCurrentElement();
            if ( ( subtfilme26.isDeleted() != 1 ) )
            {
               subfileToVariables26 ();
               sMode5 = Gx_mode ;
               Gx_mode = (String)(subtfilme26.getTrnMode()) ;
               Valid_Filatoprot ();
               Gx_mode = sMode5 ;
            }
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtFilCodigo.isEventSource(eventSource) ) {
            A28FilCodi = edtFilCodigo.getValue() ;
            return;
         }
         if ( edtFilData.isEventSource(eventSource) ) {
            A31FilData = edtFilData.getValue() ;
            n31FilData = (((DateTime.MinValue==A31FilData)) ? true : false) ;
            return;
         }
         if ( cmbFilSituacao.isEventSource(eventSource) ) {
            A30FilSitu = cmbFilSituacao.getValue() ;
            n30FilSitu = (((0==A30FilSitu)) ? true : false) ;
            return;
         }
         if ( edtFilNome.isEventSource(eventSource) ) {
            A29FilNome = edtFilNome.getValue() ;
            n29FilNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A29FilNome).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtFilDescricao.isEventSource(eventSource) ) {
            A34FilDesc = edtFilDescricao.getValue() ;
            n34FilDesc = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A34FilDesc).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( chkFilOscar.isEventSource(eventSource) ) {
            A55FilOsca = chkFilOscar.getValue() ;
            n55FilOsca = (((0==A55FilOsca)) ? true : false) ;
            return;
         }
         if ( edtCatCodigo.isEventSource(eventSource) ) {
            A32CatCodi = edtCatCodigo.getValue() ;
            n32CatCodi = (((0==A32CatCodi)) ? true : false) ;
            return;
         }
         if ( edtCatNome.isEventSource(eventSource) ) {
            A33CatNome = edtCatNome.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E13022 */
            E13022 ();
            if (!cleanedUp) {
               VariablesToControls();
            }
            return true ;
         }
         if (triggerEventEnter(eventSource, keyCode)) {
            AnyError = 0;
            btn_enter( ) ;
            if (!cleanedUp) {
               VariablesToControls();
               set_caption( );
            }
            return true ;
         }
         if (keyCode == getContext().getClientPreferences().getKEY_PROMPT()) {
            return promptHandler(eventSource);
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "BROWSE".TrimEnd(' ') ) == 0 ) )
         {
            return promptHandler(eventSource) ;
         }
         return false;
      }

      public override bool isKeyControl( Object eventSource )
      {
         if ( ( edtFilCodigo.isEventSource(eventSource) ) && ( ( A28FilCodi != edtFilCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
         if ( ( edtFilData.isEventSource(eventSource) ) && ( ( A31FilData != edtFilData.getValue() ) ) )
         {
            return true;
         }
         if ( ( cmbFilSituacao.isEventSource(eventSource) ) && ( ( A30FilSitu != cmbFilSituacao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtFilNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A29FilNome.TrimEnd(' '), edtFilNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtFilDescricao.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A34FilDesc.TrimEnd(' '), edtFilDescricao.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( chkFilOscar.isEventSource(eventSource) ) && ( ( A55FilOsca != chkFilOscar.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtCatCodigo.isEventSource(eventSource) ) && ( ( A32CatCodi != edtCatCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtCatNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A33CatNome.TrimEnd(' '), edtCatNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if (subGxsf21.elementsEventSource(eventSource))
         {
            return true;
         }
         if (subGxsf26.elementsEventSource(eventSource))
         {
            return true;
         }
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public override void resetCaption( )
      {
         ResetCaption020( ) ;
      }

      public override void setAddCaption( )
      {
      }

      public override bool getModeByParameter( )
      {
         return true ;
      }

      public override IGXButton getConfirmButton( )
      {
         return bttBtn_enter ;
      }

      public bool promptHandler( Object eventSource )
      {
         if (( subGxsf26.getColumn(0).isEventSource(eventSource) ) && ( subGxsf26.getColumn(0).isEnabled() )) {
            eventLevelContext( );
            prompt_77_5( ) ;
            eventLevelResetContext( );
            return true ;
         }
         if (( subGxsf21.getColumn(0).isEventSource(eventSource) ) && ( subGxsf21.getColumn(0).isEnabled() )) {
            eventLevelContext( );
            prompt_79_4( ) ;
            eventLevelResetContext( );
            return true ;
         }
         if (( edtCatCodigo.isEventSource(eventSource) ) && ( edtCatCodigo.isEnabled() )) {
            prompt_32_3( ) ;
            return true ;
         }
         return false;
      }

      public override void deleteLineHandler( Object eventSource ,
                                              int row )
      {
         if ( subGxsf26 .isEventSource(eventSource)) {
            if ( row < 0 ) {
               subtfilme26 = ( subtfilme26 ) subGxsf26.getCurrentElement() ;
            }
            else
            {
               subtfilme26 = ( subtfilme26 ) subGxsf26.getElementAt(row) ;
            }
            subfileToVariables26 ();
            if ( ( subtfilme26.isDeleted() == 1 ) )
            {
               sMode5 = Gx_mode ;
               Gx_mode = "DLT" ;
            }
            else
            {
               sMode5 = Gx_mode ;
               Gx_mode = "INS" ;
            }
            validate_on_delete5 ();
            Gx_mode = sMode5 ;
         }
         if ( subGxsf21 .isEventSource(eventSource)) {
            if ( row < 0 ) {
               subtfilme21 = ( subtfilme21 ) subGxsf21.getCurrentElement() ;
            }
            else
            {
               subtfilme21 = ( subtfilme21 ) subGxsf21.getElementAt(row) ;
            }
            subfileToVariables21 ();
            if ( ( subtfilme21.isDeleted() == 1 ) )
            {
               sMode4 = Gx_mode ;
               Gx_mode = "DLT" ;
            }
            else
            {
               sMode4 = Gx_mode ;
               Gx_mode = "INS" ;
            }
            validate_on_delete4 ();
            Gx_mode = sMode4 ;
         }
      }

      public override void setNoAccept( Object eventSource )
      {
         if ( edtFilData.isEventSource(eventSource) )
         {
            edtFilData.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( cmbFilSituacao.isEventSource(eventSource) )
         {
            cmbFilSituacao.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtFilNome.isEventSource(eventSource) )
         {
            edtFilNome.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtFilDescricao.isEventSource(eventSource) )
         {
            edtFilDescricao.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( chkFilOscar.isEventSource(eventSource) )
         {
            chkFilOscar.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtCatCodigo.isEventSource(eventSource) )
         {
            edtCatCodigo.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      protected void variablesToSubfile21( )
      {
         subtfilme21.setFilDirCodigo(A79FilDirC);
         subtfilme21.setFilDirNome(A80FilDirN);
      }

      protected void subfileToVariables21( )
      {
         A79FilDirC = subtfilme21.getFilDirCodigo();
         A80FilDirN = subtfilme21.getFilDirNome();
      }

      protected void variablesToSubfile26( )
      {
         subtfilme26.setFilAtoCodigo(A77FilAtoC);
         subtfilme26.setFilAtoNome(A78FilAtoN);
         subtfilme26.setFilAtoProt(A81FilAtoP);
         subtfilme26.setZFilAtoProt(Z81FilAtoP);
      }

      protected void subfileToVariables26( )
      {
         A77FilAtoC = subtfilme26.getFilAtoCodigo();
         A78FilAtoN = subtfilme26.getFilAtoNome();
         A81FilAtoP = subtfilme26.getFilAtoProt();
         n81FilAtoP = (((0==A81FilAtoP)) ? true : false) ;
         Z81FilAtoP = subtfilme26.getZFilAtoProt();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtFilCodigo.setValue( A28FilCodi );
         edtFilData.setValue( A31FilData );
         cmbFilSituacao.setValue( A30FilSitu );
         edtFilNome.setValue( A29FilNome );
         edtFilDescricao.setValue( A34FilDesc );
         chkFilOscar.setValue( A55FilOsca );
         edtCatCodigo.setValue( A32CatCodi );
         edtCatNome.setValue( A33CatNome );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         A28FilCodi = (int)(edtFilCodigo.getValue()) ;
         edtFilCodigo.setValue(A28FilCodi);
         n28FilCodi = false ;
         A31FilData = (DateTime)(edtFilData.getValue()) ;
         edtFilData.setValue(A31FilData);
         n31FilData = false ;
         n31FilData = (((DateTime.MinValue==A31FilData)) ? true : false) ;
         A30FilSitu = (short)(cmbFilSituacao.getValue()) ;
         cmbFilSituacao.setValue(A30FilSitu);
         n30FilSitu = false ;
         n30FilSitu = (((0==A30FilSitu)) ? true : false) ;
         A29FilNome = (String)(edtFilNome.getValue()) ;
         edtFilNome.setValue(A29FilNome);
         n29FilNome = false ;
         n29FilNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A29FilNome).TrimEnd(' ') )==0)) ? true : false) ;
         A34FilDesc = (String)(edtFilDescricao.getValue()) ;
         edtFilDescricao.setValue(A34FilDesc);
         n34FilDesc = false ;
         n34FilDesc = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A34FilDesc).TrimEnd(' ') )==0)) ? true : false) ;
         A55FilOsca = (short)(chkFilOscar.getValue()) ;
         chkFilOscar.setValue(A55FilOsca);
         n55FilOsca = false ;
         n55FilOsca = (((0==A55FilOsca)) ? true : false) ;
         A32CatCodi = (int)(edtCatCodigo.getValue()) ;
         edtCatCodigo.setValue(A32CatCodi);
         n32CatCodi = false ;
         n32CatCodi = (((0==A32CatCodi)) ? true : false) ;
         A33CatNome = (String)(edtCatNome.getValue()) ;
         edtCatNome.setValue(A33CatNome);
         n33CatNome = false ;
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf21.inValidElement() )
         {
            subtfilme21 = ( subtfilme21 ) subGxsf21.getCurrentElement() ;
         }
         else
         {
            subtfilme21 = new subtfilme21 ();
         }
         subfileToVariables21 ();
         if ( subGxsf26.inValidElement() )
         {
            subtfilme26 = ( subtfilme26 ) subGxsf26.getCurrentElement() ;
         }
         else
         {
            subtfilme26 = new subtfilme26 ();
         }
         subfileToVariables26 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile21 ();
         subGxsf21.refreshLineValue(subtfilme21);
         variablesToSubfile26 ();
         subGxsf26.refreshLineValue(subtfilme26);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf21.inValidElement() )
         {
            subtfilme21 = ( subtfilme21 ) subGxsf21.getCurrentElement() ;
         }
         else
         {
            subtfilme21 = new subtfilme21 ();
         }
         subfileToVariables21 ();
         if ( subGxsf26.inValidElement() )
         {
            subtfilme26 = ( subtfilme26 ) subGxsf26.getCurrentElement() ;
         }
         else
         {
            subtfilme26 = new subtfilme26 ();
         }
         subfileToVariables26 ();
      }

      protected void prompt_32_3( )
      {
         new wgx0060(context, base.remoteHandle, base.context).execute( out  A32CatCodi) ;
         edtCatCodigo.setValue( A32CatCodi );
         n32CatCodi = false ;
         setFocus(edtCatCodigo);
         ResetCaption020( ) ;
      }

      protected void prompt_79_4( )
      {
         new wgx00a0(context, base.remoteHandle, base.context).execute( out  A79FilDirC) ;
         ((subtfilme21)subGxsf21.getCurrentElement()).setFilDirCodigo(A79FilDirC);
         subGxsf21.refreshLineValue(subGxsf21.getSelectedElement());
         subGxsf21.repaint();
         ResetCaption020( ) ;
      }

      protected void prompt_77_5( )
      {
         new wgx00a0(context, base.remoteHandle, base.context).execute( out  A77FilAtoC) ;
         ((subtfilme26)subGxsf26.getCurrentElement()).setFilAtoCodigo(A77FilAtoC);
         subGxsf26.refreshLineValue(subGxsf26.getSelectedElement());
         subGxsf26.repaint();
         ResetCaption020( ) ;
      }

      protected void Valid_Filcodigo( )
      {
         if ( ( A28FilCodi != K28FilCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K28FilCodi = A28FilCodi ;
               getEqualNoModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
               {
                  StandaloneModalInsert( ) ;
               }
               VariablesToControls();
            }
            if ( ( AnyError == 0 ) )
            {
               geteqAfterKey = 0 ;
            }
            else
            {
               geteqAfterKey = 1 ;
            }
         }
         IsConfirmed = 0 ;
         set_caption( ) ;
      }

      protected void Valid_Fildata( )
      {
         if ( ! ( ((DateTime.MinValue==A31FilData)) || ( A31FilData >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXutil.msg( me(), "Campo Data de lançamento do filme fora da faixa" );
            AnyError = 1 ;
            setNextFocus( edtFilData );
            setFocusNext();
         }
         if ( true /* After */ && ( A31FilData == DateTimeUtil.CToD( "0", 2) ) )
         {
            GXutil.msg( me(), "Data de lançamento deve ser informada!" );
            AnyError = 1 ;
            setNextFocus( edtFilData );
            setFocusNext();
         }
         if ( true /* After */ && ( A31FilData > Gx_date ) )
         {
            GXutil.msg( me(), "Não é possível cadastrar um filme não lançado!" );
            AnyError = 1 ;
            setNextFocus( edtFilData );
            setFocusNext();
         }
      }

      protected void Valid_Catcodigo( )
      {
         /* Using cursor T00022 */
         pr_default.execute(0, new Object[] {n32CatCodi, A32CatCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A32CatCodi)) ) )
            {
               GXutil.msg( me(), "Não existe 'Cadastro de categorias.'." );
               AnyError = 1 ;
               setNextFocus( edtCatCodigo );
               setFocusNext();
            }
         }
         A33CatNome = T00022_A33CatNome[0] ;
         n33CatNome = T00022_n33CatNome[0] ;
         pr_default.close(0);
         edtCatNome.setValue( A33CatNome );
         if ( true /* After */ && ((0==A32CatCodi)) )
         {
            GXutil.msg( me(), "Categoria deve ser informada!" );
            AnyError = 1 ;
            setNextFocus( edtCatCodigo );
            setFocusNext();
         }
         pr_default.close(0);
      }

      protected void Valid_Filnome( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A29FilNome).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Nome deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtFilNome );
            setFocusNext();
         }
      }

      protected void Valid_Fildescricao( )
      {
      }

      protected void Valid_Fildircodigo( )
      {
         if ( ( A79FilDirC != K79FilDirC ) || ( geteqAfterKey4 == 1 ) )
         {
            /* Using cursor T00023 */
            pr_default.execute(1, new Object[] {A79FilDirC});
            if ( (pr_default.getStatus(1) == 101) )
            {
               GXutil.msg( me(), "Não existe 'Diretor do filme.'." );
               AnyError = 1 ;
               subGxsf21.cancelSubfileMove();
            }
            A80FilDirN = T00023_A80FilDirN[0] ;
            n80FilDirN = T00023_n80FilDirN[0] ;
            pr_default.close(1);
            ((subtfilme21)subGxsf21.getCurrentElement()).setFilDirNome(A80FilDirN);
            subGxsf21.refreshLineValue(subGxsf21.getSelectedElement());
            subGxsf21.repaint();
            pr_default.close(1);
            if ( ( AnyError == 0 ) )
            {
               geteqAfterKey4 = 0 ;
            }
            else
            {
               geteqAfterKey4 = 1 ;
            }
         }
      }

      protected void Valid_Fildirnome( )
      {
         reloadGridRow();
      }

      protected void validate_on_delete4( )
      {
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T00023 */
            pr_default.execute(1, new Object[] {A79FilDirC});
            A80FilDirN = T00023_A80FilDirN[0] ;
            n80FilDirN = T00023_n80FilDirN[0] ;
            pr_default.close(1);
         }
      }

      protected void Valid_Filatocodigo( )
      {
         if ( ( A77FilAtoC != K77FilAtoC ) || ( geteqAfterKey5 == 1 ) )
         {
            /* Using cursor T00024 */
            pr_default.execute(2, new Object[] {A77FilAtoC});
            if ( (pr_default.getStatus(2) == 101) )
            {
               GXutil.msg( me(), "Não existe 'Ator do filme.'." );
               AnyError = 1 ;
               subGxsf26.cancelSubfileMove();
            }
            A78FilAtoN = T00024_A78FilAtoN[0] ;
            n78FilAtoN = T00024_n78FilAtoN[0] ;
            pr_default.close(2);
            ((subtfilme26)subGxsf26.getCurrentElement()).setFilAtoNome(A78FilAtoN);
            subGxsf26.refreshLineValue(subGxsf26.getSelectedElement());
            subGxsf26.repaint();
            pr_default.close(2);
            if ( ( AnyError == 0 ) )
            {
               geteqAfterKey5 = 0 ;
            }
            else
            {
               geteqAfterKey5 = 1 ;
            }
         }
      }

      protected void Valid_Filatoprot( )
      {
         reloadGridRow();
      }

      protected void validate_on_delete5( )
      {
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T00024 */
            pr_default.execute(2, new Object[] {A77FilAtoC});
            A78FilAtoN = T00024_A78FilAtoN[0] ;
            n78FilAtoN = T00024_n78FilAtoN[0] ;
            pr_default.close(2);
         }
      }

      protected void E12022( )
      {
         eventNoLevelContext();
         /* Start Routine */
         tctrlCadastrodefilme.setActivePage(1);
      }

      protected void E11022( )
      {
         /* After Trn Routine */
         if ( ( String.CompareOrdinal(A29FilNome.TrimEnd(' '), AV7FilNome.TrimEnd(' ') ) != 0 ) && ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            GXutil.msg( me(), "Registro atualizado!" );
         }
      }

      protected void E13022( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A32CatCodi") )
         {
            new wconscategoria(context, base.remoteHandle, base.context).execute( out  A32CatCodi) ;
            edtCatCodigo.setValue( A32CatCodi );
            n32CatCodi = false ;
         }
         else if ( GXCursor("A79FilDirC") )
         {
            new wconsastro(context, base.remoteHandle, base.context).execute( out  A79FilDirC) ;
            ((subtfilme21)subGxsf21.getCurrentElement()).setFilDirCodigo(A79FilDirC);
            subGxsf21.refreshLineValue(subGxsf21.getSelectedElement());
            subGxsf21.repaint();
         }
         else if ( GXCursor("A77FilAtoC") )
         {
            new wconsastro(context, base.remoteHandle, base.context).execute( out  A77FilAtoC) ;
            ((subtfilme26)subGxsf26.getCurrentElement()).setFilAtoCodigo(A77FilAtoC);
            subGxsf26.refreshLineValue(subGxsf26.getSelectedElement());
            subGxsf26.repaint();
         }
         eventLevelResetContext();
      }

      /* Server side code */
      /* Aggregate/select formulas */
      /* Vertical formulas */
      public override void standaloneStartupServer( )
      {
         if ( ( AnyError == 0 ) )
         {
            standaloneNotModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
            {
               sMode3 = Gx_mode ;
               Gx_mode = "UPD" ;
               Gx_mode = sMode3 ;
            }
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               getByPrimaryKey( ) ;
               if ( ( RcdFound3 != 1 ) )
               {
                  pushError( GXResourceManager.GetMessage("noinsert") );
                  AnyError = 1 ;
                  keepFocus();
               }
            }
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               i31FilData = A31FilData ;
               i30FilSitu = A30FilSitu ;
            }
         }
         set_caption( ) ;
         PreviousCaption = bttBtn_enter.getCaption() ;
      }

      protected void ZM023( int GX_JID )
      {
         if ( ( GX_JID == 11 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z29FilNome = T000210_A29FilNome[0] ;
               Z30FilSitu = T000210_A30FilSitu[0] ;
               Z31FilData = T000210_A31FilData[0] ;
               Z55FilOsca = T000210_A55FilOsca[0] ;
               Z32CatCodi = T000210_A32CatCodi[0] ;
            }
            else
            {
               Z29FilNome = A29FilNome ;
               Z30FilSitu = A30FilSitu ;
               Z31FilData = A31FilData ;
               Z55FilOsca = A55FilOsca ;
               Z32CatCodi = A32CatCodi ;
            }
         }
         if ( ( GX_JID == -11 ) )
         {
            Z28FilCodi = A28FilCodi ;
            Z29FilNome = A29FilNome ;
            Z30FilSitu = A30FilSitu ;
            Z31FilData = A31FilData ;
            Z34FilDesc = A34FilDesc ;
            Z55FilOsca = A55FilOsca ;
            Z32CatCodi = A32CatCodi ;
         }
      }

      public override void standaloneNotModal( )
      {
         Gx_BScreen = 0 ;
         Gx_date = DateTimeUtil.Today( ) ;
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            edtCatCodigo.setEnabled(0);
         }
         else
         {
            edtCatCodigo.setEnabled(1);
         }
      }

      public override void standaloneModal( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((DateTime.MinValue==A31FilData)) && ( Gx_BScreen == 0 ) )
         {
            A31FilData = Gx_date ;
            edtFilData.setValue(A31FilData);
            n31FilData = false ;
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((0==A30FilSitu)) && ( Gx_BScreen == 0 ) )
         {
            A30FilSitu = 1 ;
            cmbFilSituacao.setValue(A30FilSitu);
            n30FilSitu = false ;
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            subGxsf21.setEnabled(0);
            subGxsf26.setEnabled(0);
         }
      }

      protected void Load023( )
      {
         /* Using cursor T000211 */
         pr_default.execute(9, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound3 = 1 ;
            A29FilNome = T000211_A29FilNome[0] ;
            n29FilNome = T000211_n29FilNome[0] ;
            A30FilSitu = T000211_A30FilSitu[0] ;
            n30FilSitu = T000211_n30FilSitu[0] ;
            A31FilData = T000211_A31FilData[0] ;
            n31FilData = T000211_n31FilData[0] ;
            A33CatNome = T000211_A33CatNome[0] ;
            n33CatNome = T000211_n33CatNome[0] ;
            A34FilDesc = T000211_A34FilDesc[0] ;
            n34FilDesc = T000211_n34FilDesc[0] ;
            A55FilOsca = T000211_A55FilOsca[0] ;
            n55FilOsca = T000211_n55FilOsca[0] ;
            A32CatCodi = T000211_A32CatCodi[0] ;
            n32CatCodi = T000211_n32CatCodi[0] ;
            ZM023( -11) ;
         }
         pr_default.close(9);
         OnLoadActions023( ) ;
      }

      protected void OnLoadActions023( )
      {
      }

      protected void CheckExtendedTable023( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( ! ( ((DateTime.MinValue==A31FilData)) || ( A31FilData >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            pushError( "Campo Data de lançamento do filme fora da faixa" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ( A31FilData == DateTimeUtil.CToD( "0", 2) ) )
         {
            pushError( "Data de lançamento deve ser informada!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ( A31FilData > Gx_date ) )
         {
            pushError( "Não é possível cadastrar um filme não lançado!" );
            AnyError = 1 ;
            keepFocus();
         }
         /* Using cursor T00022 */
         pr_default.execute(0, new Object[] {n32CatCodi, A32CatCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A32CatCodi)) ) )
            {
               pushError( "Não existe 'Cadastro de categorias.'." );
               AnyError = 1 ;
               setNextFocus( edtCatCodigo );
            }
         }
         A33CatNome = T00022_A33CatNome[0] ;
         n33CatNome = T00022_n33CatNome[0] ;
         pr_default.close(0);
         if ( true /* After */ && ((0==A32CatCodi)) )
         {
            pushError( "Categoria deve ser informada!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A29FilNome).TrimEnd(' ') )==0)) )
         {
            pushError( "Nome deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors023( )
      {
         pr_default.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey023( )
      {
         /* Using cursor T000212 */
         pr_default.execute(10, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound3 = 1 ;
         }
         else
         {
            RcdFound3 = 0 ;
         }
         pr_default.close(10);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T000210 */
         pr_default.execute(8, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(8) != 101) && ( T000210_A28FilCodi[0] == A28FilCodi ) )
         {
            ZM023( 11) ;
            RcdFound3 = 1 ;
            A29FilNome = T000210_A29FilNome[0] ;
            n29FilNome = T000210_n29FilNome[0] ;
            A30FilSitu = T000210_A30FilSitu[0] ;
            n30FilSitu = T000210_n30FilSitu[0] ;
            A31FilData = T000210_A31FilData[0] ;
            n31FilData = T000210_n31FilData[0] ;
            A34FilDesc = T000210_A34FilDesc[0] ;
            n34FilDesc = T000210_n34FilDesc[0] ;
            A55FilOsca = T000210_A55FilOsca[0] ;
            n55FilOsca = T000210_n55FilOsca[0] ;
            A32CatCodi = T000210_A32CatCodi[0] ;
            n32CatCodi = T000210_n32CatCodi[0] ;
            Z28FilCodi = A28FilCodi ;
            sMode3 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load023( ) ;
            Gx_mode = sMode3 ;
         }
         else
         {
            RcdFound3 = 0 ;
            InitializeNonKey023( ) ;
            sMode3 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode3 ;
         }
         K28FilCodi = A28FilCodi ;
         pr_default.close(8);
         subGxsf21.startLoad();
         subtfilme21 = new subtfilme21 ();
         if ( ( RcdFound3 == 1 ) )
         {
            ScanStart024( ) ;
            while ( ( RcdFound4 != 0 ) )
            {
               getByPrimaryKey024( ) ;
               AddRow024( ) ;
               ScanNext024( ) ;
            }
            ScanEnd024( ) ;
         }
         subGxsf21.endLoad(new subtfilme21());
         subGxsf26.startLoad();
         subtfilme26 = new subtfilme26 ();
         if ( ( RcdFound3 == 1 ) )
         {
            ScanStart025( ) ;
            while ( ( RcdFound5 != 0 ) )
            {
               getByPrimaryKey025( ) ;
               AddRow025( ) ;
               ScanNext025( ) ;
            }
            ScanEnd025( ) ;
         }
         subGxsf26.endLoad(new subtfilme26());
      }

      public override void getEqualNoModal( )
      {
         GetKey023( ) ;
         if ( ( RcdFound3 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound3 = 0 ;
         /* Using cursor T000213 */
         pr_default.execute(11, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( T000213_A28FilCodi[0] == A28FilCodi ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( T000213_A28FilCodi[0] == A28FilCodi ) )
            {
               RcdFound3 = 1 ;
            }
         }
         pr_default.close(11);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0 ;
         /* Using cursor T000214 */
         pr_default.execute(12, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( T000214_A28FilCodi[0] == A28FilCodi ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( T000214_A28FilCodi[0] == A28FilCodi ) )
            {
               RcdFound3 = 1 ;
            }
         }
         pr_default.close(12);
      }

      public override void btn_enter( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            btn_delete( ) ;
            if	(loopOnce) cleanup();
            return  ;
         }
         nKeyPressed = 1 ;
         GetKey023( ) ;
         if ( ( RcdFound3 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( edtFilCodigo );
            }
            else if ( ( A28FilCodi != Z28FilCodi ) )
            {
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtFilCodigo );
            }
            else
            {
               /* Update record */
               Update023( ) ;
               setNextFocus( edtFilCodigo );
            }
         }
         else
         {
            if ( ( A28FilCodi != Z28FilCodi ) )
            {
               /* Insert record */
               Insert023( ) ;
               setNextFocus( edtFilCodigo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( edtFilCodigo );
               }
               else
               {
                  /* Insert record */
                  Insert023( ) ;
                  setNextFocus( edtFilCodigo );
               }
            }
         }
         handleErrors();
         AfterTrn( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
         AnyError = 0 ;
         if	(loopOnce) cleanup();
      }

      public override void btn_delete( )
      {
         if ( ( A28FilCodi != Z28FilCodi ) )
         {
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtFilCodigo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( edtFilCodigo );
         }
         if ( ( AnyError != 0 ) )
         {
         }
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      protected void CheckOptimisticConcurrency023( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00029 */
            pr_default.execute(7, new Object[] {n28FilCodi, A28FilCodi});
            if ( ! (pr_default.getStatus(7) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"FILME"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(7) == 101) || ( String.CompareOrdinal(Z29FilNome.TrimEnd(' '), T00029_A29FilNome[0].TrimEnd(' ') ) != 0 ) || ( Z30FilSitu != T00029_A30FilSitu[0] ) || ( Z31FilData != T00029_A31FilData[0] ) || ( Z55FilOsca != T00029_A55FilOsca[0] ) || ( Z32CatCodi != T00029_A32CatCodi[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"FILME"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert023( )
      {
         BeforeValidate023( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable023( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM023( 0) ;
            CheckOptimisticConcurrency023( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm023( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert023( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000215 */
                     pr_default.execute(13, new Object[] {n29FilNome, A29FilNome, n30FilSitu, A30FilSitu, n31FilData, A31FilData, n34FilDesc, A34FilDesc, n55FilOsca, A55FilOsca, n32CatCodi, A32CatCodi});
                     pr_default.close(13);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000216 */
                     pr_default.execute(14);
                     A28FilCodi = T000216_A28FilCodi[0] ;
                     n28FilCodi = T000216_n28FilCodi[0] ;
                     pr_default.close(14);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           ProcessLevel023( ) ;
                           if ( ( AnyError == 0 ) )
                           {
                              loopOnce = true;
                           }
                        }
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
            else
            {
               Load023( ) ;
            }
            EndLevel023( ) ;
         }
         CloseExtendedTableCursors023( ) ;
      }

      protected void Update023( )
      {
         BeforeValidate023( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable023( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency023( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm023( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate023( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000217 */
                     pr_default.execute(15, new Object[] {n29FilNome, A29FilNome, n30FilSitu, A30FilSitu, n31FilData, A31FilData, n34FilDesc, A34FilDesc, n55FilOsca, A55FilOsca, n32CatCodi, A32CatCodi, n28FilCodi, A28FilCodi});
                     pr_default.close(15);
                     DeferredUpdate023( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           ProcessLevel023( ) ;
                           if ( ( AnyError == 0 ) )
                           {
                              loopOnce = true;
                           }
                        }
                     }
                     else
                     {
                        pushError( GXResourceManager.GetMessage("unexp") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                  }
               }
            }
            EndLevel023( ) ;
         }
         CloseExtendedTableCursors023( ) ;
      }

      protected void DeferredUpdate023( )
      {
      }

      public override void delete( )
      {
         BeforeValidate023( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency023( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls023( ) ;
            ScanStart025( ) ;
            while ( ( RcdFound5 != 0 ) )
            {
               getByPrimaryKey025( ) ;
               Delete025( ) ;
               ScanNext025( ) ;
            }
            ScanEnd025( ) ;
            ScanStart024( ) ;
            while ( ( RcdFound4 != 0 ) )
            {
               getByPrimaryKey024( ) ;
               Delete024( ) ;
               ScanNext024( ) ;
            }
            ScanEnd024( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm023( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeDelete023( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000218 */
                     pr_default.execute(16, new Object[] {n28FilCodi, A28FilCodi});
                     pr_default.close(16);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           loopOnce = true;
                        }
                     }
                     else
                     {
                        pushError( GXResourceManager.GetMessage("unexp") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                  }
               }
            }
         }
         sMode3 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel023( ) ;
         Gx_mode = sMode3 ;
      }

      protected void OnDeleteControls023( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000219 */
            pr_default.execute(17, new Object[] {n32CatCodi, A32CatCodi});
            A33CatNome = T000219_A33CatNome[0] ;
            n33CatNome = T000219_n33CatNome[0] ;
            pr_default.close(17);
         }
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000220 */
            pr_default.execute(18, new Object[] {n28FilCodi, A28FilCodi});
            if ( (pr_default.getStatus(18) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de mídias."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(18);
         }
      }

      protected void ProcessNestedLevel024( )
      {
         nGXsfl_21_idx = 0 ;
         while ( ( nGXsfl_21_idx < subGxsf21.getItemCount() ) )
         {
            ReadRow024( ) ;
            if ( ( subtfilme21.isLoaded() != 0 ) || ( subtfilme21.isChanged() != 0 ) )
            {
               standaloneNotModal024( ) ;
               GetKey024( ) ;
               if ( ( subtfilme21.isLoaded() == 0 ) && ( subtfilme21.isDeleted() == 0 ) )
               {
                  if ( ( RcdFound4 == 0 ) )
                  {
                     Gx_mode = "INS" ;
                     Insert024( ) ;
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("noupdate") );
                     AnyError = 1 ;
                     setNextFocus( edtFilCodigo );
                  }
               }
               else
               {
                  if ( ( RcdFound4 != 0 ) )
                  {
                     if ( ( subtfilme21.isDeleted() != 0 ) && ( subtfilme21.isLoaded() != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        Delete024( ) ;
                     }
                     else
                     {
                        if ( ( subtfilme21.isChanged() != 0 ) && ( subtfilme21.isLoaded() != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           Update024( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( ( subtfilme21.isDeleted() == 0 ) )
                     {
                        pushError( GXResourceManager.GetMessage("recdeleted") );
                        AnyError = 1 ;
                        setNextFocus( edtFilCodigo );
                     }
                  }
               }
            }
         }
         subGxsf21.endLoad(new subtfilme21());
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ProcessNestedLevel025( )
      {
         nGXsfl_26_idx = 0 ;
         while ( ( nGXsfl_26_idx < subGxsf26.getItemCount() ) )
         {
            ReadRow025( ) ;
            if ( ( subtfilme26.isLoaded() != 0 ) || ( subtfilme26.isChanged() != 0 ) )
            {
               standaloneNotModal025( ) ;
               GetKey025( ) ;
               if ( ( subtfilme26.isLoaded() == 0 ) && ( subtfilme26.isDeleted() == 0 ) )
               {
                  if ( ( RcdFound5 == 0 ) )
                  {
                     Gx_mode = "INS" ;
                     Insert025( ) ;
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("noupdate") );
                     AnyError = 1 ;
                     setNextFocus( edtFilCodigo );
                  }
               }
               else
               {
                  if ( ( RcdFound5 != 0 ) )
                  {
                     if ( ( subtfilme26.isDeleted() != 0 ) && ( subtfilme26.isLoaded() != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        Delete025( ) ;
                     }
                     else
                     {
                        if ( ( subtfilme26.isChanged() != 0 ) && ( subtfilme26.isLoaded() != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           Update025( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( ( subtfilme26.isDeleted() == 0 ) )
                     {
                        pushError( GXResourceManager.GetMessage("recdeleted") );
                        AnyError = 1 ;
                        setNextFocus( edtFilCodigo );
                     }
                  }
               }
            }
         }
         subGxsf26.endLoad(new subtfilme26());
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ProcessLevel023( )
      {
         /* Save parent mode. */
         sMode3 = Gx_mode ;
         ProcessNestedLevel024( ) ;
         ProcessNestedLevel025( ) ;
         if ( ( AnyError != 0 ) )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode3 ;
         /* ' Update level parameters */
      }

      protected void EndLevel023( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(7);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete023( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(8);
            pr_default.close(6);
            pr_default.close(5);
            pr_default.close(4);
            pr_default.close(3);
            pr_default.close(17);
            pr_default.close(1);
            pr_default.close(2);
            context.CommitDataStores("TFilme");
            /* After transaction rules */
            if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A34FilDesc).TrimEnd(' ') )==0)) )
            {
               GXutil.msg( me(), "Descrição não foi informada!" );
            }
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(8);
            pr_default.close(6);
            pr_default.close(5);
            pr_default.close(4);
            pr_default.close(3);
            pr_default.close(17);
            pr_default.close(1);
            pr_default.close(2);
            context.RollbackDataStores("TFilme");
            nGXsfl_21_idx = 0 ;
            while ( ( nGXsfl_21_idx < subGxsf21.getItemCount() ) )
            {
               ReadRow024( ) ;
               /* Using cursor T00028 */
               pr_default.execute(6, new Object[] {n28FilCodi, A28FilCodi, A79FilDirC});
               if ( (pr_default.getStatus(6) != 101) && ( T00028_A28FilCodi[0] == A28FilCodi ) )
               {
                  if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
                  {
                  }
                  else
                  {
                  }
                  variablesToSubfile21 ();
               }
               pr_default.close(6);
            }
         }
         IsModified = 0 ;
      }

      protected void ScanStart023( )
      {
         /* Using cursor T000221 */
         pr_default.execute(19, new Object[] {n28FilCodi, A28FilCodi});
         RcdFound3 = 0 ;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound3 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext023( )
      {
         pr_default.readNext(19);
         RcdFound3 = 0 ;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound3 = 1 ;
         }
      }

      protected void ScanEnd023( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm023( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert023( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate023( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete023( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete023( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate023( )
      {
         /* Before Validate Rules */
      }

      protected void ZM024( int GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
            }
            else
            {
            }
         }
         if ( ( GX_JID == -13 ) )
         {
            Z28FilCodi = A28FilCodi ;
            Z79FilDirC = A79FilDirC ;
         }
      }

      protected void standaloneNotModal024( )
      {
      }

      protected void standaloneModal024( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            subGxsf21.setEnabled(0);
            subGxsf26.setEnabled(0);
         }
      }

      protected void Load024( )
      {
         /* Using cursor T000222 */
         pr_default.execute(20, new Object[] {n28FilCodi, A28FilCodi, A79FilDirC});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound4 = 1 ;
            A80FilDirN = T000222_A80FilDirN[0] ;
            n80FilDirN = T000222_n80FilDirN[0] ;
            ZM024( -13) ;
         }
         pr_default.close(20);
         OnLoadActions024( ) ;
      }

      protected void OnLoadActions024( )
      {
      }

      protected void CheckExtendedTable024( )
      {
         Gx_BScreen = 1 ;
         standaloneModal024( ) ;
         Gx_BScreen = 0 ;
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A79FilDirC});
         if ( (pr_default.getStatus(1) == 101) )
         {
            pushError( "Não existe 'Diretor do filme.'." );
            AnyError = 1 ;
            setNextFocus( new GXSubfileCell(subGxsf21, nGXsfl_21_idx - 1, 0) );
         }
         A80FilDirN = T00023_A80FilDirN[0] ;
         n80FilDirN = T00023_n80FilDirN[0] ;
         pr_default.close(1);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors024( )
      {
         pr_default.close(1);
      }

      protected void enableDisable024( )
      {
      }

      protected void GetKey024( )
      {
         /* Using cursor T000223 */
         pr_default.execute(21, new Object[] {n28FilCodi, A28FilCodi, A79FilDirC});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound4 = 1 ;
         }
         else
         {
            RcdFound4 = 0 ;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey024( )
      {
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {n28FilCodi, A28FilCodi, A79FilDirC});
         if ( (pr_default.getStatus(6) != 101) && ( T00028_A28FilCodi[0] == A28FilCodi ) )
         {
            ZM024( 13) ;
            RcdFound4 = 1 ;
            InitializeNonKey024( ) ;
            A79FilDirC = T00028_A79FilDirC[0] ;
            Z28FilCodi = A28FilCodi ;
            Z79FilDirC = A79FilDirC ;
            sMode4 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load024( ) ;
            Gx_mode = sMode4 ;
         }
         else
         {
            RcdFound4 = 0 ;
            InitializeNonKey024( ) ;
            sMode4 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal024( ) ;
            Gx_mode = sMode4 ;
         }
         K79FilDirC = A79FilDirC ;
         pr_default.close(6);
      }

      protected void CheckOptimisticConcurrency024( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00027 */
            pr_default.execute(5, new Object[] {n28FilCodi, A28FilCodi, A79FilDirC});
            if ( ! (pr_default.getStatus(5) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"FILMEDIRECAO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(5) == 101) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"FILMEDIRECAO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert024( )
      {
         BeforeValidate024( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable024( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM024( 0) ;
            CheckOptimisticConcurrency024( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm024( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert024( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000224 */
                     pr_default.execute(22, new Object[] {n28FilCodi, A28FilCodi, A79FilDirC});
                     pr_default.close(22);
                     if ( (pr_default.getStatus(22) == 1) )
                     {
                        pushError( GXResourceManager.GetMessage("noupdate") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
            else
            {
               Load024( ) ;
            }
            EndLevel024( ) ;
         }
         CloseExtendedTableCursors024( ) ;
      }

      protected void Update024( )
      {
         BeforeValidate024( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable024( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency024( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm024( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate024( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* No attributes to update on table [FILMEDIRECAO] */
                     DeferredUpdate024( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey024( ) ;
                        }
                     }
                     else
                     {
                        pushError( GXResourceManager.GetMessage("unexp") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                  }
               }
            }
            EndLevel024( ) ;
         }
         CloseExtendedTableCursors024( ) ;
      }

      protected void DeferredUpdate024( )
      {
      }

      protected void Delete024( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate024( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency024( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls024( ) ;
            /* No cascading delete specified. */
            AfterConfirm024( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete024( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000225 */
                  pr_default.execute(23, new Object[] {n28FilCodi, A28FilCodi, A79FilDirC});
                  pr_default.close(23);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
         }
         sMode4 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel024( ) ;
         Gx_mode = sMode4 ;
      }

      protected void OnDeleteControls024( )
      {
         standaloneModal024( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000226 */
            pr_default.execute(24, new Object[] {A79FilDirC});
            A80FilDirN = T000226_A80FilDirN[0] ;
            n80FilDirN = T000226_n80FilDirN[0] ;
            pr_default.close(24);
         }
      }

      protected void EndLevel024( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(5);
         }
      }

      protected void ScanStart024( )
      {
         /* Using cursor T000227 */
         pr_default.execute(25, new Object[] {n28FilCodi, A28FilCodi});
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound4 = 1 ;
            A79FilDirC = T000227_A79FilDirC[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext024( )
      {
         pr_default.readNext(25);
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound4 = 1 ;
            A79FilDirC = T000227_A79FilDirC[0] ;
         }
      }

      protected void ScanEnd024( )
      {
         pr_default.close(25);
      }

      protected void AfterConfirm024( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert024( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate024( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete024( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete024( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate024( )
      {
         /* Before Validate Rules */
      }

      protected void AddRow024( )
      {
         loadToBuffer21();
      }

      protected void ReadRow024( )
      {
         subtfilme21 = ( subtfilme21 ) subGxsf21.getElementAt(nGXsfl_21_idx) ;
         subfileToVariables21 ();
         nGXsfl_21_idx = (short)(nGXsfl_21_idx+1) ;
      }

      protected void ZM025( int GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z81FilAtoP = T00026_A81FilAtoP[0] ;
            }
            else
            {
               Z81FilAtoP = A81FilAtoP ;
            }
         }
         if ( ( GX_JID == -15 ) )
         {
            Z28FilCodi = A28FilCodi ;
            Z81FilAtoP = A81FilAtoP ;
            Z77FilAtoC = A77FilAtoC ;
         }
      }

      protected void standaloneNotModal025( )
      {
      }

      protected void standaloneModal025( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            subGxsf21.setEnabled(0);
            subGxsf26.setEnabled(0);
         }
      }

      protected void Load025( )
      {
         /* Using cursor T000228 */
         pr_default.execute(26, new Object[] {n28FilCodi, A28FilCodi, A77FilAtoC});
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound5 = 1 ;
            A78FilAtoN = T000228_A78FilAtoN[0] ;
            n78FilAtoN = T000228_n78FilAtoN[0] ;
            A81FilAtoP = T000228_A81FilAtoP[0] ;
            n81FilAtoP = T000228_n81FilAtoP[0] ;
            ZM025( -15) ;
         }
         pr_default.close(26);
         OnLoadActions025( ) ;
      }

      protected void OnLoadActions025( )
      {
      }

      protected void CheckExtendedTable025( )
      {
         Gx_BScreen = 1 ;
         standaloneModal025( ) ;
         Gx_BScreen = 0 ;
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A77FilAtoC});
         if ( (pr_default.getStatus(2) == 101) )
         {
            pushError( "Não existe 'Ator do filme.'." );
            AnyError = 1 ;
            setNextFocus( new GXSubfileCell(subGxsf26, nGXsfl_26_idx - 1, 0) );
         }
         A78FilAtoN = T00024_A78FilAtoN[0] ;
         n78FilAtoN = T00024_n78FilAtoN[0] ;
         pr_default.close(2);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors025( )
      {
         pr_default.close(2);
      }

      protected void enableDisable025( )
      {
      }

      protected void GetKey025( )
      {
         /* Using cursor T000229 */
         pr_default.execute(27, new Object[] {n28FilCodi, A28FilCodi, A77FilAtoC});
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound5 = 1 ;
         }
         else
         {
            RcdFound5 = 0 ;
         }
         pr_default.close(27);
      }

      protected void getByPrimaryKey025( )
      {
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {n28FilCodi, A28FilCodi, A77FilAtoC});
         if ( (pr_default.getStatus(4) != 101) && ( T00026_A28FilCodi[0] == A28FilCodi ) )
         {
            ZM025( 15) ;
            RcdFound5 = 1 ;
            InitializeNonKey025( ) ;
            A81FilAtoP = T00026_A81FilAtoP[0] ;
            n81FilAtoP = T00026_n81FilAtoP[0] ;
            A77FilAtoC = T00026_A77FilAtoC[0] ;
            Z28FilCodi = A28FilCodi ;
            Z77FilAtoC = A77FilAtoC ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load025( ) ;
            Gx_mode = sMode5 ;
         }
         else
         {
            RcdFound5 = 0 ;
            InitializeNonKey025( ) ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal025( ) ;
            Gx_mode = sMode5 ;
         }
         K77FilAtoC = A77FilAtoC ;
         pr_default.close(4);
      }

      protected void CheckOptimisticConcurrency025( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00025 */
            pr_default.execute(3, new Object[] {n28FilCodi, A28FilCodi, A77FilAtoC});
            if ( ! (pr_default.getStatus(3) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"FILMEELENCO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z81FilAtoP != T00025_A81FilAtoP[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"FILMEELENCO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert025( )
      {
         BeforeValidate025( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable025( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM025( 0) ;
            CheckOptimisticConcurrency025( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm025( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert025( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000230 */
                     pr_default.execute(28, new Object[] {n28FilCodi, A28FilCodi, n81FilAtoP, A81FilAtoP, A77FilAtoC});
                     pr_default.close(28);
                     if ( (pr_default.getStatus(28) == 1) )
                     {
                        pushError( GXResourceManager.GetMessage("noupdate") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
            else
            {
               Load025( ) ;
            }
            EndLevel025( ) ;
         }
         CloseExtendedTableCursors025( ) ;
      }

      protected void Update025( )
      {
         BeforeValidate025( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable025( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency025( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm025( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate025( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000231 */
                     pr_default.execute(29, new Object[] {n81FilAtoP, A81FilAtoP, n28FilCodi, A28FilCodi, A77FilAtoC});
                     pr_default.close(29);
                     DeferredUpdate025( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey025( ) ;
                        }
                     }
                     else
                     {
                        pushError( GXResourceManager.GetMessage("unexp") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                  }
               }
            }
            EndLevel025( ) ;
         }
         CloseExtendedTableCursors025( ) ;
      }

      protected void DeferredUpdate025( )
      {
      }

      protected void Delete025( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate025( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency025( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls025( ) ;
            /* No cascading delete specified. */
            AfterConfirm025( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete025( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000232 */
                  pr_default.execute(30, new Object[] {n28FilCodi, A28FilCodi, A77FilAtoC});
                  pr_default.close(30);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
         }
         sMode5 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel025( ) ;
         Gx_mode = sMode5 ;
      }

      protected void OnDeleteControls025( )
      {
         standaloneModal025( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000233 */
            pr_default.execute(31, new Object[] {A77FilAtoC});
            A78FilAtoN = T000233_A78FilAtoN[0] ;
            n78FilAtoN = T000233_n78FilAtoN[0] ;
            pr_default.close(31);
         }
      }

      protected void EndLevel025( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(3);
         }
      }

      protected void ScanStart025( )
      {
         /* Using cursor T000234 */
         pr_default.execute(32, new Object[] {n28FilCodi, A28FilCodi});
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(32) != 101) )
         {
            RcdFound5 = 1 ;
            A77FilAtoC = T000234_A77FilAtoC[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext025( )
      {
         pr_default.readNext(32);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(32) != 101) )
         {
            RcdFound5 = 1 ;
            A77FilAtoC = T000234_A77FilAtoC[0] ;
         }
      }

      protected void ScanEnd025( )
      {
         pr_default.close(32);
      }

      protected void AfterConfirm025( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert025( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate025( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete025( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete025( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate025( )
      {
         /* Before Validate Rules */
      }

      protected void AddRow025( )
      {
         loadToBuffer26();
      }

      protected void ReadRow025( )
      {
         subtfilme26 = ( subtfilme26 ) subGxsf26.getElementAt(nGXsfl_26_idx) ;
         subfileToVariables26 ();
         nGXsfl_26_idx = (short)(nGXsfl_26_idx+1) ;
      }

      protected void CONFIRM_020( )
      {
         BeforeValidate023( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls023( ) ;
            }
            else
            {
               CheckExtendedTable023( ) ;
               CloseExtendedTableCursors023( ) ;
            }
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            /* Save parent mode. */
            sMode3 = Gx_mode ;
            CONFIRM_024( ) ;
            if ( ( AnyError == 0 ) )
            {
               CONFIRM_025( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Restore parent mode. */
                  Gx_mode = sMode3 ;
                  PreviousCaption = bttBtn_enter.getCaption() ;
                  PreviousTooltip = bttBtn_enter.getTooltip() ;
                  IsConfirmed = 1 ;
               }
            }
            /* Restore parent mode. */
            Gx_mode = sMode3 ;
         }
      }

      protected void CONFIRM_025( )
      {
         nGXsfl_26_idx = 0 ;
         while ( ( nGXsfl_26_idx < subGxsf26.getItemCount() ) )
         {
            ReadRow025( ) ;
            if ( ( subtfilme26.isLoaded() != 0 ) || ( subtfilme26.isChanged() != 0 ) )
            {
               GetKey025( ) ;
               if ( ( subtfilme26.isLoaded() == 0 ) && ( subtfilme26.isDeleted() == 0 ) )
               {
                  if ( ( RcdFound5 == 0 ) )
                  {
                     Gx_mode = "INS" ;
                     BeforeValidate025( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        CheckExtendedTable025( ) ;
                        CloseExtendedTableCursors025( ) ;
                        if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
                        {
                           PreviousCaption = bttBtn_enter.getCaption() ;
                           PreviousTooltip = bttBtn_enter.getTooltip() ;
                           IsConfirmed = 1 ;
                        }
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("noupdate") );
                     AnyError = 1 ;
                     setNextFocus( edtFilCodigo );
                  }
               }
               else
               {
                  if ( ( RcdFound5 != 0 ) )
                  {
                     if ( ( subtfilme26.isDeleted() != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        getByPrimaryKey025( ) ;
                        Load025( ) ;
                        BeforeValidate025( ) ;
                        if ( ( AnyError == 0 ) )
                        {
                           OnDeleteControls025( ) ;
                        }
                     }
                     else
                     {
                        if ( ( subtfilme26.isChanged() != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           BeforeValidate025( ) ;
                           if ( ( AnyError == 0 ) )
                           {
                              CheckExtendedTable025( ) ;
                              CloseExtendedTableCursors025( ) ;
                              if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
                              {
                                 PreviousCaption = bttBtn_enter.getCaption() ;
                                 PreviousTooltip = bttBtn_enter.getTooltip() ;
                                 IsConfirmed = 1 ;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( ( subtfilme26.isDeleted() == 0 ) )
                     {
                        pushError( GXResourceManager.GetMessage("recdeleted") );
                        AnyError = 1 ;
                        setNextFocus( edtFilCodigo );
                     }
                  }
               }
            }
         }
         subGxsf26.endLoad();
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_024( )
      {
         nGXsfl_21_idx = 0 ;
         while ( ( nGXsfl_21_idx < subGxsf21.getItemCount() ) )
         {
            ReadRow024( ) ;
            if ( ( subtfilme21.isLoaded() != 0 ) || ( subtfilme21.isChanged() != 0 ) )
            {
               GetKey024( ) ;
               if ( ( subtfilme21.isLoaded() == 0 ) && ( subtfilme21.isDeleted() == 0 ) )
               {
                  if ( ( RcdFound4 == 0 ) )
                  {
                     Gx_mode = "INS" ;
                     BeforeValidate024( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        CheckExtendedTable024( ) ;
                        CloseExtendedTableCursors024( ) ;
                        if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
                        {
                           PreviousCaption = bttBtn_enter.getCaption() ;
                           PreviousTooltip = bttBtn_enter.getTooltip() ;
                           IsConfirmed = 1 ;
                        }
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("noupdate") );
                     AnyError = 1 ;
                     setNextFocus( edtFilCodigo );
                  }
               }
               else
               {
                  if ( ( RcdFound4 != 0 ) )
                  {
                     if ( ( subtfilme21.isDeleted() != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        getByPrimaryKey024( ) ;
                        Load024( ) ;
                        BeforeValidate024( ) ;
                        if ( ( AnyError == 0 ) )
                        {
                           OnDeleteControls024( ) ;
                        }
                     }
                     else
                     {
                        if ( ( subtfilme21.isChanged() != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           BeforeValidate024( ) ;
                           if ( ( AnyError == 0 ) )
                           {
                              CheckExtendedTable024( ) ;
                              CloseExtendedTableCursors024( ) ;
                              if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
                              {
                                 PreviousCaption = bttBtn_enter.getCaption() ;
                                 PreviousTooltip = bttBtn_enter.getTooltip() ;
                                 IsConfirmed = 1 ;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( ( subtfilme21.isDeleted() == 0 ) )
                     {
                        pushError( GXResourceManager.GetMessage("recdeleted") );
                        AnyError = 1 ;
                        setNextFocus( edtFilCodigo );
                     }
                  }
               }
            }
         }
         subGxsf21.endLoad();
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(4);
         pr_default.close(31);
         pr_default.close(6);
         pr_default.close(24);
         pr_default.close(8);
         pr_default.close(17);
      }

      public override void initialize( )
      {
         IsConfirmed = 0 ;
         IsModified = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         A29FilNome = "" ;
         n29FilNome = false ;
         A30FilSitu = 0 ;
         n30FilSitu = false ;
         A31FilData = (DateTime)(DateTime.MinValue) ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         n31FilData = false ;
         A32CatCodi = 0 ;
         n32CatCodi = false ;
         A33CatNome = "" ;
         n33CatNome = false ;
         A34FilDesc = "" ;
         n34FilDesc = false ;
         A55FilOsca = 0 ;
         n55FilOsca = false ;
         i31FilData = (DateTime)(DateTime.MinValue) ;
         i30FilSitu = 0 ;
         A79FilDirC = 0 ;
         A80FilDirN = "" ;
         n80FilDirN = false ;
         K79FilDirC = 0 ;
         A81FilAtoP = 0 ;
         n81FilAtoP = false ;
         A77FilAtoC = 0 ;
         A78FilAtoN = "" ;
         n78FilAtoN = false ;
         K77FilAtoC = 0 ;
         subtfilme21 = new subtfilme21();
         sMode4 = "" ;
         subtfilme26 = new subtfilme26();
         sMode5 = "" ;
         lastAnyError = 0 ;
         Z81FilAtoP = 0 ;
         n28FilCodi = false ;
         scmdbuf = "" ;
         T00022_A33CatNome = new String[] {""} ;
         T00022_n33CatNome = new bool[] {false} ;
         T00023_A80FilDirN = new String[] {""} ;
         T00023_n80FilDirN = new bool[] {false} ;
         T00024_A78FilAtoN = new String[] {""} ;
         T00024_n78FilAtoN = new bool[] {false} ;
         AV7FilNome = "" ;
         sMode3 = "" ;
         RcdFound3 = 0 ;
         Z29FilNome = "" ;
         Z30FilSitu = 0 ;
         Z31FilData = (DateTime)(DateTime.MinValue) ;
         Z55FilOsca = 0 ;
         Z32CatCodi = 0 ;
         GX_JID = 0 ;
         Z28FilCodi = 0 ;
         Z34FilDesc = "" ;
         Gx_BScreen = 0 ;
         T000211_A28FilCodi = new int[1] ;
         T000211_n28FilCodi = new bool[] {false} ;
         T000211_A29FilNome = new String[] {""} ;
         T000211_n29FilNome = new bool[] {false} ;
         T000211_A30FilSitu = new short[1] ;
         T000211_n30FilSitu = new bool[] {false} ;
         T000211_A31FilData = new DateTime[] {DateTime.MinValue} ;
         T000211_n31FilData = new bool[] {false} ;
         T000211_A33CatNome = new String[] {""} ;
         T000211_n33CatNome = new bool[] {false} ;
         T000211_A34FilDesc = new String[] {""} ;
         T000211_n34FilDesc = new bool[] {false} ;
         T000211_A55FilOsca = new short[1] ;
         T000211_n55FilOsca = new bool[] {false} ;
         T000211_A32CatCodi = new int[1] ;
         T000211_n32CatCodi = new bool[] {false} ;
         T000212_A28FilCodi = new int[1] ;
         T000212_n28FilCodi = new bool[] {false} ;
         T000210_A28FilCodi = new int[1] ;
         T000210_n28FilCodi = new bool[] {false} ;
         T000210_A29FilNome = new String[] {""} ;
         T000210_n29FilNome = new bool[] {false} ;
         T000210_A30FilSitu = new short[1] ;
         T000210_n30FilSitu = new bool[] {false} ;
         T000210_A31FilData = new DateTime[] {DateTime.MinValue} ;
         T000210_n31FilData = new bool[] {false} ;
         T000210_A34FilDesc = new String[] {""} ;
         T000210_n34FilDesc = new bool[] {false} ;
         T000210_A55FilOsca = new short[1] ;
         T000210_n55FilOsca = new bool[] {false} ;
         T000210_A32CatCodi = new int[1] ;
         T000210_n32CatCodi = new bool[] {false} ;
         RcdFound4 = 0 ;
         RcdFound5 = 0 ;
         T000213_A28FilCodi = new int[1] ;
         T000213_n28FilCodi = new bool[] {false} ;
         T000214_A28FilCodi = new int[1] ;
         T000214_n28FilCodi = new bool[] {false} ;
         T00029_A28FilCodi = new int[1] ;
         T00029_n28FilCodi = new bool[] {false} ;
         T00029_A29FilNome = new String[] {""} ;
         T00029_n29FilNome = new bool[] {false} ;
         T00029_A30FilSitu = new short[1] ;
         T00029_n30FilSitu = new bool[] {false} ;
         T00029_A31FilData = new DateTime[] {DateTime.MinValue} ;
         T00029_n31FilData = new bool[] {false} ;
         T00029_A34FilDesc = new String[] {""} ;
         T00029_n34FilDesc = new bool[] {false} ;
         T00029_A55FilOsca = new short[1] ;
         T00029_n55FilOsca = new bool[] {false} ;
         T00029_A32CatCodi = new int[1] ;
         T00029_n32CatCodi = new bool[] {false} ;
         T000216_A28FilCodi = new int[1] ;
         T000216_n28FilCodi = new bool[] {false} ;
         T000219_A33CatNome = new String[] {""} ;
         T000219_n33CatNome = new bool[] {false} ;
         T000220_A37MidCodi = new int[1] ;
         T00028_A28FilCodi = new int[1] ;
         T00028_n28FilCodi = new bool[] {false} ;
         T00028_A79FilDirC = new int[1] ;
         T000221_A28FilCodi = new int[1] ;
         T000221_n28FilCodi = new bool[] {false} ;
         Z79FilDirC = 0 ;
         T000222_A28FilCodi = new int[1] ;
         T000222_n28FilCodi = new bool[] {false} ;
         T000222_A80FilDirN = new String[] {""} ;
         T000222_n80FilDirN = new bool[] {false} ;
         T000222_A79FilDirC = new int[1] ;
         T000223_A28FilCodi = new int[1] ;
         T000223_n28FilCodi = new bool[] {false} ;
         T000223_A79FilDirC = new int[1] ;
         T00027_A28FilCodi = new int[1] ;
         T00027_n28FilCodi = new bool[] {false} ;
         T00027_A79FilDirC = new int[1] ;
         T000226_A80FilDirN = new String[] {""} ;
         T000226_n80FilDirN = new bool[] {false} ;
         T000227_A28FilCodi = new int[1] ;
         T000227_n28FilCodi = new bool[] {false} ;
         T000227_A79FilDirC = new int[1] ;
         Z77FilAtoC = 0 ;
         T000228_A28FilCodi = new int[1] ;
         T000228_n28FilCodi = new bool[] {false} ;
         T000228_A78FilAtoN = new String[] {""} ;
         T000228_n78FilAtoN = new bool[] {false} ;
         T000228_A81FilAtoP = new short[1] ;
         T000228_n81FilAtoP = new bool[] {false} ;
         T000228_A77FilAtoC = new int[1] ;
         T000229_A28FilCodi = new int[1] ;
         T000229_n28FilCodi = new bool[] {false} ;
         T000229_A77FilAtoC = new int[1] ;
         T00026_A28FilCodi = new int[1] ;
         T00026_n28FilCodi = new bool[] {false} ;
         T00026_A81FilAtoP = new short[1] ;
         T00026_n81FilAtoP = new bool[] {false} ;
         T00026_A77FilAtoC = new int[1] ;
         T00025_A28FilCodi = new int[1] ;
         T00025_n28FilCodi = new bool[] {false} ;
         T00025_A81FilAtoP = new short[1] ;
         T00025_n81FilAtoP = new bool[] {false} ;
         T00025_A77FilAtoC = new int[1] ;
         T000233_A78FilAtoN = new String[] {""} ;
         T000233_n78FilAtoN = new bool[] {false} ;
         T000234_A28FilCodi = new int[1] ;
         T000234_n28FilCodi = new bool[] {false} ;
         T000234_A77FilAtoC = new int[1] ;
         K28FilCodi = 0 ;
         n28FilCodi = false ;
         A30FilSitu = 1 ;
         n30FilSitu = false ;
         A31FilData = Gx_date ;
         n31FilData = false ;
         Gx_date = DateTimeUtil.Today( ) ;
         A55FilOsca = 0 ;
         n55FilOsca = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tfilme__default(),
            new Object[][] {
                new Object[] {
               T00022_A33CatNome, T00022_n33CatNome
               }
               , new Object[] {
               T00023_A80FilDirN, T00023_n80FilDirN
               }
               , new Object[] {
               T00024_A78FilAtoN, T00024_n78FilAtoN
               }
               , new Object[] {
               T00025_A28FilCodi, T00025_A81FilAtoP, T00025_n81FilAtoP, T00025_A77FilAtoC
               }
               , new Object[] {
               T00026_A28FilCodi, T00026_A81FilAtoP, T00026_n81FilAtoP, T00026_A77FilAtoC
               }
               , new Object[] {
               T00027_A28FilCodi, T00027_A79FilDirC
               }
               , new Object[] {
               T00028_A28FilCodi, T00028_A79FilDirC
               }
               , new Object[] {
               T00029_A28FilCodi, T00029_A29FilNome, T00029_n29FilNome, T00029_A30FilSitu, T00029_n30FilSitu, T00029_A31FilData, T00029_n31FilData, T00029_A34FilDesc, T00029_n34FilDesc, T00029_A55FilOsca,
               T00029_n55FilOsca, T00029_A32CatCodi, T00029_n32CatCodi
               }
               , new Object[] {
               T000210_A28FilCodi, T000210_A29FilNome, T000210_n29FilNome, T000210_A30FilSitu, T000210_n30FilSitu, T000210_A31FilData, T000210_n31FilData, T000210_A34FilDesc, T000210_n34FilDesc, T000210_A55FilOsca,
               T000210_n55FilOsca, T000210_A32CatCodi, T000210_n32CatCodi
               }
               , new Object[] {
               T000211_A28FilCodi, T000211_A29FilNome, T000211_n29FilNome, T000211_A30FilSitu, T000211_n30FilSitu, T000211_A31FilData, T000211_n31FilData, T000211_A33CatNome, T000211_n33CatNome, T000211_A34FilDesc,
               T000211_n34FilDesc, T000211_A55FilOsca, T000211_n55FilOsca, T000211_A32CatCodi, T000211_n32CatCodi
               }
               , new Object[] {
               T000212_A28FilCodi
               }
               , new Object[] {
               T000213_A28FilCodi
               }
               , new Object[] {
               T000214_A28FilCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000216_A28FilCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000219_A33CatNome, T000219_n33CatNome
               }
               , new Object[] {
               T000220_A37MidCodi
               }
               , new Object[] {
               T000221_A28FilCodi
               }
               , new Object[] {
               T000222_A28FilCodi, T000222_A80FilDirN, T000222_n80FilDirN, T000222_A79FilDirC
               }
               , new Object[] {
               T000223_A28FilCodi, T000223_A79FilDirC
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000226_A80FilDirN, T000226_n80FilDirN
               }
               , new Object[] {
               T000227_A28FilCodi, T000227_A79FilDirC
               }
               , new Object[] {
               T000228_A28FilCodi, T000228_A78FilAtoN, T000228_n78FilAtoN, T000228_A81FilAtoP, T000228_n81FilAtoP, T000228_A77FilAtoC
               }
               , new Object[] {
               T000229_A28FilCodi, T000229_A77FilAtoC
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000233_A78FilAtoN, T000233_n78FilAtoN
               }
               , new Object[] {
               T000234_A28FilCodi, T000234_A77FilAtoC
               }
            }
         );
         reloadDynamicLists(0);
         K28FilCodi = 0 ;
         edtFilCodigo.setValue(A28FilCodi);
         n28FilCodi = false ;
         A30FilSitu = 1 ;
         cmbFilSituacao.setValue(A30FilSitu);
         n30FilSitu = false ;
         A31FilData = Gx_date ;
         edtFilData.setValue(A31FilData);
         n31FilData = false ;
         Gx_date = DateTimeUtil.Today( ) ;
         A55FilOsca = 0 ;
         chkFilOscar.setValue(A55FilOsca);
         n55FilOsca = false ;
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short A30FilSitu ;
      protected short A55FilOsca ;
      protected short geteqAfterKey= 1 ;
      protected short i30FilSitu ;
      protected short geteqAfterKey4= 1 ;
      protected short A81FilAtoP ;
      protected short geteqAfterKey5= 1 ;
      protected short Z81FilAtoP ;
      protected short RcdFound3 ;
      protected short Z30FilSitu ;
      protected short Z55FilOsca ;
      protected short Gx_BScreen ;
      protected short RcdFound4 ;
      protected short RcdFound5 ;
      protected short nGXsfl_21_idx=1 ;
      protected short nGXsfl_26_idx=1 ;
      protected int trnEnded ;
      protected int A32CatCodi ;
      protected int K28FilCodi ;
      protected int A28FilCodi ;
      protected int A79FilDirC ;
      protected int K79FilDirC ;
      protected int A77FilAtoC ;
      protected int K77FilAtoC ;
      protected int lastAnyError ;
      protected int Z32CatCodi ;
      protected int GX_JID ;
      protected int Z28FilCodi ;
      protected int Z79FilDirC ;
      protected int Z77FilAtoC ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String sMode4 ;
      protected String sMode5 ;
      protected String scmdbuf ;
      protected String sMode3 ;
      protected DateTime A31FilData ;
      protected DateTime Gx_date ;
      protected DateTime i31FilData ;
      protected DateTime Z31FilData ;
      protected bool n29FilNome ;
      protected bool n30FilSitu ;
      protected bool n31FilData ;
      protected bool n32CatCodi ;
      protected bool n33CatNome ;
      protected bool n34FilDesc ;
      protected bool n55FilOsca ;
      protected bool n80FilDirN ;
      protected bool n81FilAtoP ;
      protected bool n78FilAtoN ;
      protected bool n28FilCodi ;
      protected String A34FilDesc ;
      protected String Z34FilDesc ;
      protected String A29FilNome ;
      protected String A33CatNome ;
      protected String A80FilDirN ;
      protected String A78FilAtoN ;
      protected String AV7FilNome ;
      protected String Z29FilNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected IGXButton bttBtn_enter ;
      protected GXTabControl tctrlCadastrodefilme ;
      protected GXTabPage tpagetpage3 ;
      protected GUIObjectInt edtFilCodigo ;
      protected GUIObjectShort cmbFilSituacao ;
      protected GUIObjectDatetime edtFilData ;
      protected GUIObjectInt edtCatCodigo ;
      protected GUIObjectString edtCatNome ;
      protected GUIObjectString edtFilNome ;
      protected GUIObjectString edtFilDescricao ;
      protected GUIObjectShort chkFilOscar ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl5 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl18 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl12 ;
      protected GXTabPage tpagetpage19 ;
      protected GXSubfileTRN subGxsf21 ;
      protected ILabel lbllbl20 ;
      protected GXTabPage tpagetpage24 ;
      protected GXSubfileTRN subGxsf26 ;
      protected ILabel lbllbl25 ;
      protected subtfilme21 subtfilme21 ;
      protected subtfilme26 subtfilme26 ;
      protected IDataReader T00022 ;
      protected IDataStoreProvider pr_default ;
      protected String[] T00022_A33CatNome ;
      protected bool[] T00022_n33CatNome ;
      protected IDataReader T00023 ;
      protected String[] T00023_A80FilDirN ;
      protected bool[] T00023_n80FilDirN ;
      protected IDataReader T00024 ;
      protected String[] T00024_A78FilAtoN ;
      protected bool[] T00024_n78FilAtoN ;
      protected IDataReader T00025 ;
      protected IDataReader T00026 ;
      protected IDataReader T00027 ;
      protected IDataReader T00028 ;
      protected IDataReader T00029 ;
      protected IDataReader T000210 ;
      protected IDataReader T000211 ;
      protected int[] T000211_A28FilCodi ;
      protected bool[] T000211_n28FilCodi ;
      protected String[] T000211_A29FilNome ;
      protected bool[] T000211_n29FilNome ;
      protected short[] T000211_A30FilSitu ;
      protected bool[] T000211_n30FilSitu ;
      protected DateTime[] T000211_A31FilData ;
      protected bool[] T000211_n31FilData ;
      protected String[] T000211_A33CatNome ;
      protected bool[] T000211_n33CatNome ;
      protected String[] T000211_A34FilDesc ;
      protected bool[] T000211_n34FilDesc ;
      protected short[] T000211_A55FilOsca ;
      protected bool[] T000211_n55FilOsca ;
      protected int[] T000211_A32CatCodi ;
      protected bool[] T000211_n32CatCodi ;
      protected IDataReader T000212 ;
      protected int[] T000212_A28FilCodi ;
      protected bool[] T000212_n28FilCodi ;
      protected int[] T000210_A28FilCodi ;
      protected bool[] T000210_n28FilCodi ;
      protected String[] T000210_A29FilNome ;
      protected bool[] T000210_n29FilNome ;
      protected short[] T000210_A30FilSitu ;
      protected bool[] T000210_n30FilSitu ;
      protected DateTime[] T000210_A31FilData ;
      protected bool[] T000210_n31FilData ;
      protected String[] T000210_A34FilDesc ;
      protected bool[] T000210_n34FilDesc ;
      protected short[] T000210_A55FilOsca ;
      protected bool[] T000210_n55FilOsca ;
      protected int[] T000210_A32CatCodi ;
      protected bool[] T000210_n32CatCodi ;
      protected IDataReader T000213 ;
      protected int[] T000213_A28FilCodi ;
      protected bool[] T000213_n28FilCodi ;
      protected IDataReader T000214 ;
      protected int[] T000214_A28FilCodi ;
      protected bool[] T000214_n28FilCodi ;
      protected int[] T00029_A28FilCodi ;
      protected bool[] T00029_n28FilCodi ;
      protected String[] T00029_A29FilNome ;
      protected bool[] T00029_n29FilNome ;
      protected short[] T00029_A30FilSitu ;
      protected bool[] T00029_n30FilSitu ;
      protected DateTime[] T00029_A31FilData ;
      protected bool[] T00029_n31FilData ;
      protected String[] T00029_A34FilDesc ;
      protected bool[] T00029_n34FilDesc ;
      protected short[] T00029_A55FilOsca ;
      protected bool[] T00029_n55FilOsca ;
      protected int[] T00029_A32CatCodi ;
      protected bool[] T00029_n32CatCodi ;
      protected IDataReader T000216 ;
      protected int[] T000216_A28FilCodi ;
      protected bool[] T000216_n28FilCodi ;
      protected IDataReader T000219 ;
      protected String[] T000219_A33CatNome ;
      protected bool[] T000219_n33CatNome ;
      protected IDataReader T000220 ;
      protected int[] T000220_A37MidCodi ;
      protected int[] T00028_A28FilCodi ;
      protected bool[] T00028_n28FilCodi ;
      protected int[] T00028_A79FilDirC ;
      protected IDataReader T000221 ;
      protected int[] T000221_A28FilCodi ;
      protected bool[] T000221_n28FilCodi ;
      protected IDataReader T000222 ;
      protected int[] T000222_A28FilCodi ;
      protected bool[] T000222_n28FilCodi ;
      protected String[] T000222_A80FilDirN ;
      protected bool[] T000222_n80FilDirN ;
      protected int[] T000222_A79FilDirC ;
      protected IDataReader T000223 ;
      protected int[] T000223_A28FilCodi ;
      protected bool[] T000223_n28FilCodi ;
      protected int[] T000223_A79FilDirC ;
      protected int[] T00027_A28FilCodi ;
      protected bool[] T00027_n28FilCodi ;
      protected int[] T00027_A79FilDirC ;
      protected IDataReader T000226 ;
      protected String[] T000226_A80FilDirN ;
      protected bool[] T000226_n80FilDirN ;
      protected IDataReader T000227 ;
      protected int[] T000227_A28FilCodi ;
      protected bool[] T000227_n28FilCodi ;
      protected int[] T000227_A79FilDirC ;
      protected IDataReader T000228 ;
      protected int[] T000228_A28FilCodi ;
      protected bool[] T000228_n28FilCodi ;
      protected String[] T000228_A78FilAtoN ;
      protected bool[] T000228_n78FilAtoN ;
      protected short[] T000228_A81FilAtoP ;
      protected bool[] T000228_n81FilAtoP ;
      protected int[] T000228_A77FilAtoC ;
      protected IDataReader T000229 ;
      protected int[] T000229_A28FilCodi ;
      protected bool[] T000229_n28FilCodi ;
      protected int[] T000229_A77FilAtoC ;
      protected int[] T00026_A28FilCodi ;
      protected bool[] T00026_n28FilCodi ;
      protected short[] T00026_A81FilAtoP ;
      protected bool[] T00026_n81FilAtoP ;
      protected int[] T00026_A77FilAtoC ;
      protected int[] T00025_A28FilCodi ;
      protected bool[] T00025_n28FilCodi ;
      protected short[] T00025_A81FilAtoP ;
      protected bool[] T00025_n81FilAtoP ;
      protected int[] T00025_A77FilAtoC ;
      protected IDataReader T000233 ;
      protected String[] T000233_A78FilAtoN ;
      protected bool[] T000233_n78FilAtoN ;
      protected IDataReader T000234 ;
      protected int[] T000234_A28FilCodi ;
      protected bool[] T000234_n28FilCodi ;
      protected int[] T000234_A77FilAtoC ;
   }

   public class tfilme__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[2])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[3])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[4])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[5])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[6])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[7])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[13])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[14])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[15])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[16])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[17])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[18])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[19])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[20])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[21])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[22])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[23])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[24])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[25])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[26])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[27])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[28])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[29])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[30])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[31])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[32])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000213 ;
          prmT000213 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000214 ;
          prmT000214 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000215 ;
          prmT000215 = new Object[] {
          new Object[] {"@FilNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@FilSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilData",SqlDbType.DateTime,8,0} ,
          new Object[] {"@FilDescricao",SqlDbType.Text,800,0} ,
          new Object[] {"@FilOscar",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000216 ;
          prmT000216 = new Object[] {
          } ;
          Object[] prmT000217 ;
          prmT000217 = new Object[] {
          new Object[] {"@FilNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@FilSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilData",SqlDbType.DateTime,8,0} ,
          new Object[] {"@FilDescricao",SqlDbType.Text,800,0} ,
          new Object[] {"@FilOscar",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000218 ;
          prmT000218 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000219 ;
          prmT000219 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000220 ;
          prmT000220 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000221 ;
          prmT000221 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000222 ;
          prmT000222 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilDirCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@FilDirCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000223 ;
          prmT000223 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilDirCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilDirCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilDirCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000224 ;
          prmT000224 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilDirCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000225 ;
          prmT000225 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilDirCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000226 ;
          prmT000226 = new Object[] {
          new Object[] {"@FilDirCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000227 ;
          prmT000227 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000228 ;
          prmT000228 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000229 ;
          prmT000229 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000230 ;
          prmT000230 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilAtoProt",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000231 ;
          prmT000231 = new Object[] {
          new Object[] {"@FilAtoProt",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000232 ;
          prmT000232 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000233 ;
          prmT000233 = new Object[] {
          new Object[] {"@FilAtoCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000234 ;
          prmT000234 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00022", "SELECT [CatNome] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00023", "SELECT [AstNome] AS FilDirNome FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @FilDirCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00024", "SELECT [AstNome] AS FilAtoNome FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @FilAtoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00025", "SELECT [FilCodigo], [FilAtoProt], [FilAtoCodigo] AS FilAtoCodigo FROM [FILMEELENCO] WITH (UPDLOCK) WHERE [FilCodigo] = @FilCodigo AND [FilAtoCodigo] = @FilAtoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00026", "SELECT [FilCodigo], [FilAtoProt], [FilAtoCodigo] AS FilAtoCodigo FROM [FILMEELENCO] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo AND [FilAtoCodigo] = @FilAtoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00027", "SELECT [FilCodigo], [FilDirCodigo] AS FilDirCodigo FROM [FILMEDIRECAO] WITH (UPDLOCK) WHERE [FilCodigo] = @FilCodigo AND [FilDirCodigo] = @FilDirCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00028", "SELECT [FilCodigo], [FilDirCodigo] AS FilDirCodigo FROM [FILMEDIRECAO] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo AND [FilDirCodigo] = @FilDirCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00029", "SELECT [FilCodigo], [FilNome], [FilSituacao], [FilData], [FilDescricao], [FilOscar], [CatCodigo] FROM [FILME] WITH (UPDLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000210", "SELECT [FilCodigo], [FilNome], [FilSituacao], [FilData], [FilDescricao], [FilOscar], [CatCodigo] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000210,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000211", "SELECT TM1.[FilCodigo], TM1.[FilNome], TM1.[FilSituacao], TM1.[FilData], T2.[CatNome], TM1.[FilDescricao], TM1.[FilOscar], TM1.[CatCodigo] FROM ([FILME] TM1 WITH (NOLOCK) LEFT JOIN [CATEGORIA] T2 WITH (NOLOCK) ON T2.[CatCodigo] = TM1.[CatCodigo]) WHERE TM1.[FilCodigo] = @FilCodigo ORDER BY TM1.[FilCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000211,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000212", "SELECT [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000212,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000213", "SELECT TOP 1 [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ORDER BY [FilCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000213,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000214", "SELECT TOP 1 [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ORDER BY [FilCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000214,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000215", "INSERT INTO [FILME] ([FilNome], [FilSituacao], [FilData], [FilDescricao], [FilOscar], [CatCodigo]) VALUES (@FilNome, @FilSituacao, @FilData, @FilDescricao, @FilOscar, @CatCodigo)", GxErrorMask.GX_NOMASK,prmT000215)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000216", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000216,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000217", "UPDATE [FILME] SET [FilNome]=@FilNome, [FilSituacao]=@FilSituacao, [FilData]=@FilData, [FilDescricao]=@FilDescricao, [FilOscar]=@FilOscar, [CatCodigo]=@CatCodigo  WHERE [FilCodigo] = @FilCodigo", GxErrorMask.GX_NOMASK,prmT000217)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000218", "DELETE FROM [FILME]  WHERE [FilCodigo] = @FilCodigo", GxErrorMask.GX_NOMASK,prmT000218)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000219", "SELECT [CatNome] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000219,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000220", "SELECT TOP 1 [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000220,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000221", "SELECT [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ORDER BY [FilCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000221,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000222", "SELECT T1.[FilCodigo], T2.[AstNome] AS FilDirNome, T1.[FilDirCodigo] AS FilDirCodigo FROM ([FILMEDIRECAO] T1 WITH (NOLOCK) INNER JOIN [ASTRO] T2 WITH (NOLOCK) ON T2.[AstCodigo] = T1.[FilDirCodigo]) WHERE T1.[FilCodigo] = @FilCodigo and T1.[FilDirCodigo] = @FilDirCodigo ORDER BY T1.[FilCodigo], T1.[FilDirCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000222,25,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000223", "SELECT [FilCodigo], [FilDirCodigo] AS FilDirCodigo FROM [FILMEDIRECAO] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo AND [FilDirCodigo] = @FilDirCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000223,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000224", "INSERT INTO [FILMEDIRECAO] ([FilCodigo], [FilDirCodigo]) VALUES (@FilCodigo, @FilDirCodigo)", GxErrorMask.GX_NOMASK,prmT000224)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000225", "DELETE FROM [FILMEDIRECAO]  WHERE [FilCodigo] = @FilCodigo AND [FilDirCodigo] = @FilDirCodigo", GxErrorMask.GX_NOMASK,prmT000225)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000226", "SELECT [AstNome] AS FilDirNome FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @FilDirCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000226,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000227", "SELECT [FilCodigo], [FilDirCodigo] AS FilDirCodigo FROM [FILMEDIRECAO] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ORDER BY [FilCodigo], [FilDirCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000227,25,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000228", "SELECT T1.[FilCodigo], T2.[AstNome] AS FilAtoNome, T1.[FilAtoProt], T1.[FilAtoCodigo] AS FilAtoCodigo FROM ([FILMEELENCO] T1 WITH (NOLOCK) INNER JOIN [ASTRO] T2 WITH (NOLOCK) ON T2.[AstCodigo] = T1.[FilAtoCodigo]) WHERE T1.[FilCodigo] = @FilCodigo and T1.[FilAtoCodigo] = @FilAtoCodigo ORDER BY T1.[FilCodigo], T1.[FilAtoCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000228,25,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000229", "SELECT [FilCodigo], [FilAtoCodigo] AS FilAtoCodigo FROM [FILMEELENCO] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo AND [FilAtoCodigo] = @FilAtoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000229,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000230", "INSERT INTO [FILMEELENCO] ([FilCodigo], [FilAtoProt], [FilAtoCodigo]) VALUES (@FilCodigo, @FilAtoProt, @FilAtoCodigo)", GxErrorMask.GX_NOMASK,prmT000230)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000231", "UPDATE [FILMEELENCO] SET [FilAtoProt]=@FilAtoProt  WHERE [FilCodigo] = @FilCodigo AND [FilAtoCodigo] = @FilAtoCodigo", GxErrorMask.GX_NOMASK,prmT000231)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000232", "DELETE FROM [FILMEELENCO]  WHERE [FilCodigo] = @FilCodigo AND [FilAtoCodigo] = @FilAtoCodigo", GxErrorMask.GX_NOMASK,prmT000232)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000233", "SELECT [AstNome] AS FilAtoNome FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] = @FilAtoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000233,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000234", "SELECT [FilCodigo], [FilAtoCodigo] AS FilAtoCodigo FROM [FILMEELENCO] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ORDER BY [FilCodigo], [FilAtoCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000234,25,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getLongVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((int[]) buf[13])[0] = rslt.getInt(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 18 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 19 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 20 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                break;
             case 21 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 25 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 26 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                break;
             case 27 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 31 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 32 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 13 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Text );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[11]);
                }
                break;
             case 15 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Text );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[13]);
                }
                break;
             case 16 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 17 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 18 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 19 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 20 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 21 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 22 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 23 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 24 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 25 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 26 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 27 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 28 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                stmt.SetParameter(3, (int)parms[4]);
                break;
             case 29 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
                }
                stmt.SetParameter(3, (int)parms[4]);
                break;
             case 30 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 31 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 32 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
       }
    }

 }

}
