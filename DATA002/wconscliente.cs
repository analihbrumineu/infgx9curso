/*
               File: ConsCliente
        Description: Consulta de cliente.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 8:22:54.51
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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class wconscliente : GXWorkpanel
   {
      public wconscliente( int hnd ,
                           ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconscliente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconscliente( IGxContext context ,
                           int hnd ,
                           ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConsCliente" ;
      }

      public override String getFrmTitle( )
      {
         return "Consulta de cliente." ;
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
         return 858 ;
      }

      public override int getFrmHeight( )
      {
         return 780 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConsCliente.htm";
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

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( ref String aP0_TratErro ,
                           out int aP1_PesCodigoRet )
      {
         this.AV14TratEr = aP0_TratErro;
         this.AV10PesCod = 0 ;
         executePrivate();
         aP0_TratErro=this.AV14TratEr;
         aP1_PesCodigoRet=this.AV10PesCod;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load10( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwconscliente10 = new subwconscliente10 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV5PesCodi ,
                                              AV6PesNome ,
                                              AV13PesBai ,
                                              AV8PesSitu ,
                                              A13PesCodi ,
                                              A14PesNome ,
                                              A19PesBair ,
                                              A23PesSitu ,
                                              AV7PesDepT ,
                                              A48PesDepT ,
                                              A38PesTipo },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000R2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf10.getSize() < 10000 ) ) )
         {
            A38PesTipo = W000R2_A38PesTipo[0] ;
            n38PesTipo = W000R2_n38PesTipo[0] ;
            A23PesSitu = W000R2_A23PesSitu[0] ;
            n23PesSitu = W000R2_n23PesSitu[0] ;
            A19PesBair = W000R2_A19PesBair[0] ;
            n19PesBair = W000R2_n19PesBair[0] ;
            A14PesNome = W000R2_A14PesNome[0] ;
            n14PesNome = W000R2_n14PesNome[0] ;
            A13PesCodi = W000R2_A13PesCodi[0] ;
            A48PesDepT = GetPesDepTotal0( A13PesCodi) ;
            if ( ( AV7PesDepT == 0 ) || ( ( A48PesDepT == AV7PesDepT ) ) )
            {
               /* Execute user event: E11V0R2 */
               E11V0R2 ();
            }
            pr_default.readNext(0);
         }
         if ( subGxsf10.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConsCliente_load10 : GXLoadProducer
      {
         wconscliente _sf ;

         public ConsCliente_load10( wconscliente uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer10();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load10();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors10();
         }

      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         if ( ! gxIsRefreshing )
         {
            gxIsRefreshing = true ;
            ControlsToVariables();
            standAlone();
            VariablesToControls();
            subGxsf10.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow10( )
      {
         return true;
      }

      public void autoRefresh_flow10( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV7PesDepT!=cV7PesDepT) ) || (!loadedFirstTime && ! isLoadAtStartup_flow10() )) {
            subfile.refresh();
            resetSubfileConditions_flow10() ;
         }
      }

      public bool getSearch_flow10( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow10( )
      {
         cV7PesDepT = AV7PesDepT ;
      }

      public void resetSearchConditions_flow10( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow10( )
      {
         return new subwconscliente10 ();
      }

      public bool getSearch_flow10( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow10( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow10( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow10( )
      {
         GXRefreshCommand10 ();
      }

      public class ConsCliente_flow10 : GXSubfileFlow
      {
         wconscliente _sf ;

         public ConsCliente_flow10( wconscliente uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow10();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow10(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow10();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow10();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow10(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow10();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow10(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow10(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow10(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow10();
         }

      }

      protected void GXRefreshCommand10( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXStart( )
      {
         /* Execute user event: E12V0R2 */
         E12V0R2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V0R2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV8PesSitu = 9 ;
         cmbavPessituacao.setValue(AV8PesSitu);
      }

      public override void GXExit( )
      {
         /* Execute user event: E13V0R2 */
         E13V0R2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
            }
            if (true) return;
         }
      }

      protected void E13V0R2( )
      {
         eventLevelContext();
         /* Exit Routine */
         AV15PesDep = A13PesCodi ;
         /* Using cursor W000R3 */
         pr_default.execute(1, new Object[] {AV15PesDep});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A13PesCodi = W000R3_A13PesCodi[0] ;
            A15PesCPF = W000R3_A15PesCPF[0] ;
            n15PesCPF = W000R3_n15PesCPF[0] ;
            A83Depende = W000R3_A83Depende[0] ;
            n83Depende = W000R3_n83Depende[0] ;
            if ( ( A83Depende != 1 ) && ( String.CompareOrdinal(AV14TratEr.TrimEnd(' '), "Inativo".TrimEnd(' ') ) == 0 ) )
            {
               AV14TratEr = "Ativo" ;
            }
            else
            {
               AV10PesCod = A13PesCodi ;
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      protected void E14V0R2( )
      {
         eventLevelContext();
         /* PesCodigo_Click Routine */
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
      }

      public override void GXEnter( )
      {
         /* Execute user event: E15V0R2 */
         E15V0R2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E15V0R2( )
      {
         eventLevelContext();
         /* Enter Routine */
      }

      public void loadToBuffer10( )
      {
         subwconscliente10 oAux = subwconscliente10 ;
         subwconscliente10 = new subwconscliente10 ();
         variablesToSubfile10 ();
         subGxsf10.addElement(subwconscliente10);
         subwconscliente10 = oAux;
      }

      private void E11V0R2( )
      {
         /* Load Routine */
         subGxsf10.loadCommand();
      }

      protected void closeCursors10( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 858 , 780 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavPescodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),117, 65, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 117 , 65 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5PesCodi" );
         ((GXEdit) edtavPescodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavPescodigo.addFocusListener(this);
         edtavPescodigo.getGXComponent().setHelpId("HLP_WConsCliente.htm");
         edtavPesbairro = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),247, 65, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 247 , 65 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV13PesBai" );
         ((GXEdit) edtavPesbairro.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesbairro.addFocusListener(this);
         edtavPesbairro.getGXComponent().setHelpId("HLP_WConsCliente.htm");
         cmbavPessituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 689 , 65 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8PesSitu" );
         ((GXComboBox) cmbavPessituacao.getGXComponent()).addItem( new java.lang.Short(9),"Todos");
         ((GXComboBox) cmbavPessituacao.getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) cmbavPessituacao.getGXComponent()).addItem( new java.lang.Short(0),"Inativo");
         cmbavPessituacao.addFocusListener(this);
         cmbavPessituacao.addItemListener(this);
         cmbavPessituacao.getGXComponent().setHelpId("HLP_WConsCliente.htm");
         edtavPesnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),117, 91, 455, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 117 , 91 , 455 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6PesNome" );
         ((GXEdit) edtavPesnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesnome.addFocusListener(this);
         edtavPesnome.getGXComponent().setHelpId("HLP_WConsCliente.htm");
         edtavPesdeptotal = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),676, 91, 78, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 676 , 91 , 78 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7PesDepT" );
         ((GXEdit) edtavPesdeptotal.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavPesdeptotal.addFocusListener(this);
         edtavPesdeptotal.getGXComponent().setHelpId("HLP_WConsCliente.htm");
         addSubfile ( subGxsf10  = new GXSubfile ( new ConsCliente_load10(this), new ConsCliente_flow10(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 92, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 91 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A13PesCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 91 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 403, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 402 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A14PesNome" ), "Nome"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 402 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 358, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 357 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A19PesBair" ), "Bairro"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 357 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 97 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A23PesSitu" ), "Situação"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 97 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 90, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 89 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A48PesDepT" ), "Dependente(s)"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 89 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 34 , 18 , GXPanel1 , 65 , 117 , 739 , 637 ,  18 ));
         ((GXComboBox) subGxsf10.getColumn(3).getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) subGxsf10.getColumn(3).getGXComponent()).addItem( new java.lang.Short(0),"Inativo");
         subGxsf10.addActionListener(this);
         subGxsf10.addFocusListener(this);
         subGxsf10.setSortOnClick(true);
         subGxsf10.getColumn(0).addActionListener( this);
         subGxsf10.getColumn(0).addItemListener( this);
         lbllbl16 = UIFactory.getLabel(GXPanel1, "Consulta de clientes", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 116 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 69 , 40 , 13 );
         lbllbl17 = UIFactory.getLabel(GXPanel1, "Bairro", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 208 , 69 , 34 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 624 , 69 , 51 , 13 );
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Nome", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 95 , 33 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Dependente(s)", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 585 , 95 , 84 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavPescodigo ,
                   edtavPesbairro ,
                   cmbavPessituacao ,
                   edtavPesnome ,
                   edtavPesdeptotal ,
                   subGxsf10
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf10, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile10( )
      {
         subwconscliente10.setPesCodigo(A13PesCodi);
         subwconscliente10.setPesNome(A14PesNome);
         subwconscliente10.setPesBairro(A19PesBair);
         subwconscliente10.setPesSituacao(A23PesSitu);
         subwconscliente10.setPesDepTotal(A48PesDepT);
      }

      protected void subfileToVariables10( )
      {
         A13PesCodi = subwconscliente10.getPesCodigo();
         A14PesNome = subwconscliente10.getPesNome();
         A19PesBair = subwconscliente10.getPesBairro();
         A23PesSitu = subwconscliente10.getPesSituacao();
         A48PesDepT = subwconscliente10.getPesDepTotal();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavPescodigo.setValue( AV5PesCodi );
         edtavPesdeptotal.setValue( AV7PesDepT );
         edtavPesnome.setValue( AV6PesNome );
         cmbavPessituacao.setValue( AV8PesSitu );
         edtavPesbairro.setValue( AV13PesBai );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5PesCodi = (int)(edtavPescodigo.getValue()) ;
         edtavPescodigo.setValue(AV5PesCodi);
         AV7PesDepT = (int)(edtavPesdeptotal.getValue()) ;
         edtavPesdeptotal.setValue(AV7PesDepT);
         AV6PesNome = (String)(edtavPesnome.getValue()) ;
         edtavPesnome.setValue(AV6PesNome);
         AV8PesSitu = (short)(cmbavPessituacao.getValue()) ;
         cmbavPessituacao.setValue(AV8PesSitu);
         AV13PesBai = (String)(edtavPesbairro.getValue()) ;
         edtavPesbairro.setValue(AV13PesBai);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf10.inValidElement() )
         {
            subwconscliente10 = ( subwconscliente10 ) subGxsf10.getCurrentElement() ;
         }
         else
         {
            subwconscliente10 = new subwconscliente10 ();
         }
         subfileToVariables10 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile10 ();
         subGxsf10.refreshLineValue(subwconscliente10);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf10.inValidElement() )
         {
            subwconscliente10 = ( subwconscliente10 ) subGxsf10.getCurrentElement() ;
         }
         else
         {
            subwconscliente10 = new subwconscliente10 ();
         }
         subfileToVariables10 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf10.isEventSource(eventSource) ) {
            /* Execute user event: E15V0R2 */
            E15V0R2 ();
            return;
         }
         if ( subGxsf10.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E14V0R2 */
            E14V0R2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavPescodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavPescodigo.getGXCursor() );
            return;
         }
         if ( edtavPesdeptotal.isEventSource(eventSource) ) {
            setGXCursor( edtavPesdeptotal.getGXCursor() );
            return;
         }
         if ( edtavPesnome.isEventSource(eventSource) ) {
            setGXCursor( edtavPesnome.getGXCursor() );
            return;
         }
         if ( cmbavPessituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbavPessituacao.getGXCursor() );
            return;
         }
         if ( edtavPesbairro.isEventSource(eventSource) ) {
            setGXCursor( edtavPesbairro.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavPescodigo.isEventSource(eventSource) ) {
            AV5PesCodi = edtavPescodigo.getValue() ;
            return;
         }
         if ( edtavPesdeptotal.isEventSource(eventSource) ) {
            AV7PesDepT = edtavPesdeptotal.getValue() ;
            return;
         }
         if ( edtavPesnome.isEventSource(eventSource) ) {
            AV6PesNome = edtavPesnome.getValue() ;
            return;
         }
         if ( cmbavPessituacao.isEventSource(eventSource) ) {
            AV8PesSitu = cmbavPessituacao.getValue() ;
            return;
         }
         if ( edtavPesbairro.isEventSource(eventSource) ) {
            AV13PesBai = edtavPesbairro.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf10.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0R2 */
            E14V0R2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (triggerEventEnter(eventSource, keyCode)) {
            /* Execute user event: E15V0R2 */
            E15V0R2 ();
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      protected int GetPesDepTotal0( int E13PesCodi )
      {
         Gx_cnt = 0 ;
         /* Using cursor W000R4 */
         pr_default.execute(2, new Object[] {E13PesCodi});
         if ( (pr_default.getStatus(2) != 101) )
         {
            Gx_cnt = W000R4_Gx_cnt[0] ;
         }
         pr_default.close(2);
         return Gx_cnt ;
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
            /* Execute user event: E13V0R2 */
            E13V0R2 ();
         }
         this.AV14TratEr = AV14TratEr;
         this.AV10PesCod = AV10PesCod;
         stopThreads();
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
      }

      public override void initialize( )
      {
         subwconscliente10 = new subwconscliente10();
         scmdbuf = "" ;
         AV5PesCodi = 0 ;
         AV6PesNome = "" ;
         AV13PesBai = "" ;
         AV8PesSitu = 0 ;
         A13PesCodi = 0 ;
         A14PesNome = "" ;
         A19PesBair = "" ;
         A23PesSitu = 0 ;
         AV7PesDepT = 0 ;
         A48PesDepT = 0 ;
         A38PesTipo = 0 ;
         W000R2_A38PesTipo = new short[1] ;
         W000R2_n38PesTipo = new bool[] {false} ;
         W000R2_A23PesSitu = new short[1] ;
         W000R2_n23PesSitu = new bool[] {false} ;
         W000R2_A19PesBair = new String[] {""} ;
         W000R2_n19PesBair = new bool[] {false} ;
         W000R2_A14PesNome = new String[] {""} ;
         W000R2_n14PesNome = new bool[] {false} ;
         W000R2_A13PesCodi = new int[1] ;
         n38PesTipo = false ;
         n23PesSitu = false ;
         n19PesBair = false ;
         n14PesNome = false ;
         gxIsRefreshing = false ;
         cV7PesDepT = 0 ;
         returnInSub = false ;
         AV15PesDep = 0 ;
         W000R3_A13PesCodi = new int[1] ;
         W000R3_A15PesCPF = new String[] {""} ;
         W000R3_n15PesCPF = new bool[] {false} ;
         W000R3_A83Depende = new short[1] ;
         W000R3_n83Depende = new bool[] {false} ;
         A15PesCPF = "" ;
         n15PesCPF = false ;
         A83Depende = 0 ;
         n83Depende = false ;
         Gx_cnt = 0 ;
         E13PesCodi = 0 ;
         W000R4_Gx_cnt = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconscliente__default(),
            new Object[][] {
                new Object[] {
               W000R2_A38PesTipo, W000R2_n38PesTipo, W000R2_A23PesSitu, W000R2_n23PesSitu, W000R2_A19PesBair, W000R2_n19PesBair, W000R2_A14PesNome, W000R2_n14PesNome, W000R2_A13PesCodi
               }
               , new Object[] {
               W000R3_A13PesCodi, W000R3_A15PesCPF, W000R3_n15PesCPF, W000R3_A83Depende, W000R3_n83Depende
               }
               , new Object[] {
               W000R4_Gx_cnt
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV8PesSitu ;
      protected short A23PesSitu ;
      protected short A38PesTipo ;
      protected short A83Depende ;
      protected int AV5PesCodi ;
      protected int A13PesCodi ;
      protected int AV7PesDepT ;
      protected int A48PesDepT ;
      protected int cV7PesDepT ;
      protected int AV15PesDep ;
      protected int AV10PesCod ;
      protected int Gx_cnt ;
      protected int E13PesCodi ;
      protected String scmdbuf ;
      protected bool n38PesTipo ;
      protected bool n23PesSitu ;
      protected bool n19PesBair ;
      protected bool n14PesNome ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected bool n15PesCPF ;
      protected bool n83Depende ;
      protected String AV14TratEr ;
      protected String AV6PesNome ;
      protected String AV13PesBai ;
      protected String A14PesNome ;
      protected String A19PesBair ;
      protected String A15PesCPF ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected String aP0_TratErro ;
      protected subwconscliente10 subwconscliente10 ;
      protected IDataReader W000R2 ;
      protected IDataStoreProvider pr_default ;
      protected short[] W000R2_A38PesTipo ;
      protected bool[] W000R2_n38PesTipo ;
      protected short[] W000R2_A23PesSitu ;
      protected bool[] W000R2_n23PesSitu ;
      protected String[] W000R2_A19PesBair ;
      protected bool[] W000R2_n19PesBair ;
      protected String[] W000R2_A14PesNome ;
      protected bool[] W000R2_n14PesNome ;
      protected int[] W000R2_A13PesCodi ;
      protected IDataReader W000R3 ;
      protected int[] W000R3_A13PesCodi ;
      protected String[] W000R3_A15PesCPF ;
      protected bool[] W000R3_n15PesCPF ;
      protected short[] W000R3_A83Depende ;
      protected bool[] W000R3_n83Depende ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavPescodigo ;
      protected GUIObjectString edtavPesbairro ;
      protected GUIObjectShort cmbavPessituacao ;
      protected GUIObjectString edtavPesnome ;
      protected GUIObjectInt edtavPesdeptotal ;
      protected GXSubfile subGxsf10 ;
      protected ILabel lbllbl16 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl17 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl8 ;
      protected IDataReader W000R4 ;
      protected int[] W000R4_Gx_cnt ;
      protected int aP1_PesCodigoRet ;
   }

   public class wconscliente__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000R2( int AV5PesCodi ,
                                           String AV6PesNome ,
                                           String AV13PesBai ,
                                           short AV8PesSitu ,
                                           int A13PesCodi ,
                                           String A14PesNome ,
                                           String A19PesBair ,
                                           short A23PesSitu ,
                                           int AV7PesDepT ,
                                           int A48PesDepT ,
                                           short A38PesTipo )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [PesTipo], [PesSituacao], [PesBairro], [PesNome], [PesCodigo] FROM [PESSOA] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([PesTipo] = 1)" ;
         sWhereString = "" ;
         if ( ( AV5PesCodi != 0 ) )
         {
            sWhereString = sWhereString + " and ([PesCodigo] = " + StringUtil.Str( (decimal)(AV5PesCodi), 9, 0) + ")" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV6PesNome).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and ([PesNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6PesNome, "'", "''")), 50, "%") + "')" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV13PesBai).TrimEnd(' ') )==0)) )
         {
            sWhereString = sWhereString + " and ([PesBairro] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV13PesBai, "'", "''")), 50, "%") + "')" ;
         }
         if ( ( AV8PesSitu != 9 ) )
         {
            sWhereString = sWhereString + " and ([PesSituacao] = " + StringUtil.Str( (decimal)(AV8PesSitu), 1, 0) + ")" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [PesCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000R2( (int)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (short)dynConstraints[10] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW000R3 ;
          prmW000R3 = new Object[] {
          new Object[] {"@AV15PesDep",SqlDbType.Int,9,0}
          } ;
          Object[] prmW000R4 ;
          prmW000R4 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmW000R2 ;
          prmW000R2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000R2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000R2,28,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000R3", "SELECT [PesCodigo], [PesCPF], [Depende] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @AV15PesDep ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000R3,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W000R4", "SELECT COUNT(*) FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000R4,1,0,true,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
