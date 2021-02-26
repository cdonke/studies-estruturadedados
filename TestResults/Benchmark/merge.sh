#!/bin/bash

mergeFiles() {
  local _readme="$1"
  local _file="$2"

  CONTENT="$(sed '/Benchmark/q' $README)
$(cat $FILE)";
  echo "$CONTENT" > $README 
}

BASEPATH="../../"
for FILE in *.md;
do
  TMP_PATH="${FILE//[.]/\/}"
  REPORT_PATH="${TMP_PATH/\/md/\.md}"
  README_PATH="$BASEPATH$(dirname "$REPORT_PATH")"
  README="$README_PATH/README.md"

  if [ -f "$README" ];
  then
    if grep -q "^# Benchmark" $README;
    then
      mergeFiles "$README" "$FILE"
    else
      REPORT=$(basename "$REPORT_PATH")
      README_REPORT="README_${REPORT/-report-github.md/""}"
      README="$README_PATH/$README_REPORT.md"

      if [ -f "$README" ];
      then
        mergeFiles "$README" "$FILE"
      fi
    fi
  fi
done