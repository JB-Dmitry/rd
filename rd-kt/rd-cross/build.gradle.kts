import com.jetbrains.rd.gradle.plugins.applyCrossTest
import com.jetbrains.rd.gradle.plugins.applyKotlinJVM
import com.jetbrains.rd.gradle.tasks.creatingCopySourcesTask
import org.jetbrains.kotlin.gradle.tasks.KotlinCompile

applyKotlinJVM()
applyCrossTest()

plugins {
    kotlin("jvm")
}

sourceSets {
    main {
        compileClasspath = configurations.compileClasspath.get().minus(files(gradle.gradleHomeDir?.resolve("lib")?.listFiles()?.filter { it.name.contains("kotlin-stdlib") || it.name.contains("kotlin-reflect") } ?: listOf<File>()))
    }
}

val testCopySources by creatingCopySourcesTask(kotlin.sourceSets.main, evaluationDependsOn(":rd-gen").sourceSets["models"])

tasks {
    withType<KotlinCompile> {
        dependsOn(testCopySources)
    }
}
