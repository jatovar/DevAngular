/// <reference path="./typings.d.ts" />
// DevExtreme Globalize integration
import 'devextreme/localization/globalize/number'
import 'devextreme/localization/globalize/date'
import 'devextreme/localization/globalize/currency'
import 'devextreme/localization/globalize/message'

// DevExtreme messages (en messages already included)
import * as deMessages from 'devextreme/localization/messages/es.json'

// CLDR data
import * as  deCaGregorian from 'cldr-data/main/es-MX/ca-gregorian.json'
import * as  deNumbers from 'cldr-data/main/es-MX/numbers.json'
import * as  deCurrencies from 'cldr-data/main/es-MX/currencies.json'

import * as  likelySubtags from 'cldr-data/supplemental/likelySubtags.json'
import * as  timeData from 'cldr-data/supplemental/timeData.json'
import * as  weekData from 'cldr-data/supplemental/weekData.json'
import * as  currencyData from 'cldr-data/supplemental/currencyData.json'
import * as  numberingSystems from 'cldr-data/supplemental/numberingSystems.json'

import * as Globalize from 'globalize'

Globalize.load(
    deCaGregorian,
    deNumbers,
    deCurrencies,

    likelySubtags,
    timeData,
    weekData,
    currencyData,
    numberingSystems
);

Globalize.loadMessages(deMessages);

Globalize.locale('es-MX');