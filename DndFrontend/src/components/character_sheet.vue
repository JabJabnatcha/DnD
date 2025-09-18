<template>
    <div>
        <v-row>
            <v-col>
                <h1>Character Name</h1> <!-- String No Script -->
            </v-col>
            <v-col>
                <v-row>
                    <h2>Class & Level</h2> <!-- FK from Class -->
                    <h3>Subclass</h3> <!-- FK from Subclass -->
                </v-row>
                <v-row>
                    <h2>Race</h2> <!-- FK from Race -->
                    <h3>Subrace</h3> <!-- FK from Subrace -->
                </v-row>
            </v-col>
            <v-col>
                <v-row>
                    <h2>Background</h2> <!-- FK from Background -->
                </v-row>
                <v-row>
                    <h2>Alignment</h2> <!-- FK from Alignment -->
                </v-row>
            </v-col>
            <v-col>
            <v-row>
                <h1>Player Name</h1> <!-- String No Script -->
            </v-row>
            <v-row>
                <h2>EXP</h2> <!-- EXP Current / Next Level -->
            </v-row>
        </v-col>
        </v-row>
    </div>
</template>

<script>
import { h } from 'vue';

</script>

<style>
</style>